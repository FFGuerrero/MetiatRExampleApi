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
    /// Represent query handler to get all books
    /// </summary>
    public class GetBookListHandler : IRequestHandler<GetBookListQuery, List<BookModel>>
    {
        private readonly IDataRepository _dataRepository;

        /// <summary>
        /// Define contructor to inject dependencies
        /// </summary>
        /// <param name="dataRepository"></param>
        public GetBookListHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        /// <summary>
        /// Handles a GetBookList request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<BookModel>> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetBooks());
        }
    }
}
