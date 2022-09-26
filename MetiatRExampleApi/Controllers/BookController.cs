using MediatR;
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
        public async Task<List<BookModel>> Get()
        {
            return await _mediator.Send(new GetBookListQuery());
        }
    }
}
