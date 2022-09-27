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
    /// Represent query to get a book by Id
    /// </summary>
    /// <param name="Id">Book identifier</param>
    public record GetBookByIdQuery(int Id) : IRequest<BookModel>;
}
