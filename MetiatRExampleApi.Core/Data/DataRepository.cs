using MetiatRExampleApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Data
{
    /// <summary>
    /// Class implementation for data repository
    /// </summary>
    public class DataRepository : IDataRepository
    {
        //Use a list instead of a database for this moment
        private static List<BookModel> _books = new()
        {
            new BookModel { Id = 1, Name = "Test book 1", Cost = 500 } ,
            new BookModel { Id = 2, Name = "Test book 2", Cost = 800 }
        };

        /// <summary>
        /// Add new book to database
        /// </summary>
        /// <param name="book"></param>
        /// <returns>New created book</returns>
        public BookModel AddBook(BookModel book)
        {
            _books.Add(book);
            return book;
        }

        /// <summary>
        /// Get all available books
        /// </summary>
        /// <returns>List of available books on database</returns>
        public List<BookModel> GetBooks()
        {
            return _books;
        }
    }
}
