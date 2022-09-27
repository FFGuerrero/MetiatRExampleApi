using MediatR;
using MetiatRExampleApi.Core.Data;
using MetiatRExampleApi.Core.Models;
using MetiatRExampleApi.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Handlers
{
    /// <summary>
    /// Represent query handler to get a book by Id
    /// </summary>
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, BookModel>
    {
        private readonly IDataRepository _dataRepository;

        /// <summary>
        /// Define contructor to inject dependencies
        /// </summary>
        /// <param name="dataRepository"></param>
        public GetBookByIdHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        /// <summary>
        /// Handles a GetBookByIdQuery request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>List of books</returns>
        /// 
        public Task<BookModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetBookById(request.Id));
        }
    }
}
