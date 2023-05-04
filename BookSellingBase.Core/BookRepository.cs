using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellingBase.Core
{
    public class BookRepository
    {
        readonly string InsertBookQuery = "INSERT INTO [dbo].[Book] ([Name], [Rating],[Discription],[Year],[CategoryID]) OUTPUT INSERTED.Id VALUES(@Name, @Rating, @Discription,@Year, @CategoryID)";
        readonly string InsertBookAuthorQuery = "INSERT INTO [dbo].[BookAuthor] ([AuthorID],[BookID]) VALUES(@AuthorID, @BookID)";
        readonly string InsertCommentQuery = "INSERT INTO [dbo].[BookComment] ([Text],[RatingValue],[CustomerID],[BookID],[Date]) VALUES(@Text,@RaitingValue,@CustomerID,@BookID, @Date)";
        private string connectionString;
        public BookRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        }
        public List<CatalogBook> AllBookList()//for customer
        {
            List<CatalogBook> books;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                books = db.Query<CatalogBook>("dbo.GetCatalogBooks",
                commandType: CommandType.StoredProcedure).ToList();
            }
            return books;
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> authors;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                authors = db.Query<Author>("SELECT [Author].ID, [Author].Name from [Author]").ToList();
            }
            return authors;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                categories = db.Query<Category>("SELECT [Categories].ID, [Categories].Name from [Categories]").ToList();
            }
            return categories;
        }

        public void CreateNewAuthor(string Name)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                var sqlQuery = "INSERT INTO Author (Name) VALUES(@Name)";
                var newId = db.Query<int>(sqlQuery, new { Name }).FirstOrDefault();
            }
        }


        public List<CatalogBook> TraderBookList(string name)//for trader
        {
            List<CatalogBook> books;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                books = db.Query<CatalogBook>("SELECT [Book].ID, [Book].Name, [dbo].GetBookAutors(Book.ID) as Author, " +
                    "[Book].Rating,  [Book].Discription,  [Book].Year, [Categories].Name as Category, Trader.Name as TraderName, " +
                    "TraderBook.Cost   FROM [Book] join[Categories] on[Categories].ID = [Book].CategoryID " +
                    "join TraderBook on TraderBook.BookID = Book.ID " +
                    "join Trader on Trader.ID = TraderBook.TraderID WHERE Trader.Name = @name", new { name }).ToList();
            }
            return books;
        }

        public List<BookNameID> GetBooksNames()
        {
            List<BookNameID> booksNames = new List<BookNameID>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                booksNames = db.Query<BookNameID>("SELECT Book.ID, Book.Name FROM Book").ToList();
            }
            return booksNames;
        }

        public void CreateBookComment(BookComment newComment)
        {
            if (newComment != null)
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    db.Execute(InsertCommentQuery,
                        new { newComment.Text, RaitingValue = newComment.RatingValue, newComment.CustomerID, newComment.BookID, newComment.Date });
                    db.Execute("CalculateBookRating", new { BookId = newComment.BookID }, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<BookComment> GetBookComments(int bookId)
        {
            List<BookComment> bookComments;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                bookComments = db.Query<BookComment>("SELECT bc.[ID], [Text],[RatingValue],bc.[BookID], c.[Name] as CustomerName, [Date] FROM [BookComment] bc join [Customer] c on c.ID = bc.CustomerID WHERE bc.BookID = @bookId",
                    new { bookId }).ToList();
            }
            return bookComments;
        }

        public List<BookComment> GetAllBookComments()
        {
            List<BookComment> bookComments;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                bookComments = db.Query<BookComment>("SELECT bc.[ID], [Text],[RatingValue],bc.[BookID], c.[Name] as CustomerName, [Date] FROM [BookComment] bc join [Customer] c on c.ID = bc.CustomerID").ToList();
            }
            return bookComments;
        }

        public void DeleteBookComment(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM [BookComment] WHERE ID = @id";
                db.Execute(sqlQuery, new { id });
            }
        }

        public void CreateNewTraderBook(int TraderID, int BookID, double Cost, int Count)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {

                var sqlQuery = "INSERT INTO TraderBook (TraderID, BookID, Cost, Count) VALUES(@TraderID, @BookID, @Cost, @Count)";//; SELECT CAST(SCOPE_IDENTITY() as int)
                var newId = db.Query<int>(sqlQuery, new { TraderID, BookID, Cost, Count }).FirstOrDefault();
            }
        }

        public List<Book> GetBooks()//for admin
        {
            List<Book> books;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                books = db.Query<Book>("select * from Book").ToList();
                foreach (var book in books) 
                {
                    book.AuthorList = db.Query<Author>("select a.* from Author a join BookAuthor ba on a.ID = ba.AuthorID where ba.BookID = @BookID", new {BookID = book.ID }).ToList();
                }
            }
            return books;
        }


        public void CreateBook(Book newbook)
        {
            if (newbook != null)
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var newId = connection.QuerySingle<int>(InsertBookQuery, new { newbook.Name, Rating = 0, newbook.Discription, newbook.Year, newbook.CategoryID }, transaction: transaction);

                            object[] insertValues = new object[newbook.AuthorList.Count];
                            for (int i = 0; i < newbook.AuthorList.Count; i++)
                            {
                                insertValues[i] = new { AuthorID = newbook.AuthorList[i].ID, BookID = newId };
                            }

                            var affectedRows2 = connection.Execute(InsertBookAuthorQuery, insertValues, transaction: transaction);

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }

                }
            }
        }

        //public User Get(int id)
        //{
        //    User user = null;
        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        user = db.Query<User>("SELECT * FROM Users WHERE Id = @id", new { id }).FirstOrDefault();
        //    }
        //    return user;
        //}

        //public User Create(User user)
        //{
        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        var sqlQuery = "INSERT INTO Users (Name, Age) VALUES(@Name, @Age); SELECT CAST(SCOPE_IDENTITY() as int)";
        //        int? userId = db.Query<int>(sqlQuery, user).FirstOrDefault();
        //        user.Id = userId;
        //    }
        //    return user;
        //}

        //public void Update(User user)
        //{
        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        var sqlQuery = "UPDATE Users SET Name = @Name, Age = @Age WHERE Id = @Id";
        //        db.Execute(sqlQuery, user);
        //    }
        //}

        //public void Delete(int id)
        //{
        //    using (IDbConnection db = new SqlConnection(connectionString))
        //    {
        //        var sqlQuery = "DELETE FROM Users WHERE Id = @id";
        //        db.Execute(sqlQuery, new { id });
        //    }
        //}
    }
}
