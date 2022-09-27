using MetiatRExampleApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Data
{
    /// <summary>
    /// Contract to book data repository
    /// </summary>
    public interface IDataRepository
    {
        /// <summary>
        /// Get all available books
        /// </summary>
        /// <returns>List of available books on database</returns>
        List<BookModel> GetBooks();

        /// <summary>
        /// Add new book to database
        /// </summary>
        /// <param name="book"></param>
        /// <returns>New created book</returns>
        BookModel AddBook(BookModel book);

        /// <summary>
        /// Get existing book by Id
        /// </summary>
        /// <param name="Id">Book unique identifier</param>
        /// <returns>Existing book instance</returns>
        BookModel GetBookById(int Id);
    }
}
