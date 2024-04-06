using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDapper.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? CodeBar { get; set; }
        public decimal? Stock { get; set; }
    }
}
