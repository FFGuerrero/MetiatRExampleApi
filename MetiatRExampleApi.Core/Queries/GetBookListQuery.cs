using MediatR;
using MetiatRExampleApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Queries
{
    /// <summary>
    /// Represent query for get all books
    /// </summary>
    public record GetBookListQuery() : IRequest<List<BookModel>>;
}
