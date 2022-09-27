using MediatR;
using MetiatRExampleApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Commands
{
    /// <summary>
    /// Add book command
    /// </summary>
    /// <param name="model">Book model to be added</param>
    public record AddBookCommand(BookModel model) : IRequest<BookModel>;
}
