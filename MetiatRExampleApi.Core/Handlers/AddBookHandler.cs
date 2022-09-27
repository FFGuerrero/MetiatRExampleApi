using MediatR;
using MetiatRExampleApi.Core.Commands;
using MetiatRExampleApi.Core.Data;
using MetiatRExampleApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Handlers
{
    /// <summary>
    /// Represent command handler to add a book
    /// </summary>
    public class AddBookHandler : IRequestHandler<AddBookCommand, BookModel>
    {
        private readonly IDataRepository _dataRepository;

        /// <summary>
        /// Define contructor to inject dependencies
        /// </summary>
        /// <param name="dataRepository"></param>
        public AddBookHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        /// <summary>
        /// Handles a AddBookCommand request
        /// </summary>
        /// <param name="request">The request to add a book</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Added book</returns>
        public Task<BookModel> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddBook(request.model));
        }
    }
}
