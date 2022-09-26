using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetiatRExampleApi.Core.Models
{
    /// <summary>
    /// Class that represent book model
    /// </summary>
    public class BookModel
    {
        /// <summary>
        /// Book unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Book name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Book cost
        /// </summary>
        public decimal Cost { get; set; }
    }
}
