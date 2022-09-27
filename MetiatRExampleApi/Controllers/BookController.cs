using MediatR;
using MetiatRExampleApi.Core.Commands;
using MetiatRExampleApi.Core.Models;
using MetiatRExampleApi.Core.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetiatRExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Define contructor to inject dependencies
        /// </summary>
        /// <param name="mediator"></param>
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get list of books
        /// </summary>
        /// <returns>List of books</returns>
        [HttpGet]
        [Produces("application/json")]
        public async Task<List<BookModel>> Get()
        {
            return await _mediator.Send(new GetBookListQuery());
        }

        /// <summary>
        /// Get book object by Id
        /// </summary>
        /// <param name="Id">Book unique identifier</param>
        /// <returns>Book object from database</returns>
        /// <response code="204">If no book exists with provided Id</response>
        /// <response code="204">Success request</response>
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Produces("application/json")]
        public async Task<BookModel> Get(int Id)
        {
            return await _mediator.Send(new GetBookByIdQuery(Id));
        }

        /// <summary>
        /// Add new book
        /// </summary>
        /// <param name="bookModel">Book model to be added</param>
        /// <returns>Added book model</returns>
        [HttpPost]
        [Produces("application/json")]
        public async Task<BookModel> Post(BookModel bookModel)
        {
            return await _mediator.Send(new AddBookCommand(bookModel));
        }
    }
}
