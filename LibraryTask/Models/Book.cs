using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask.Models
{
    public class Book
    {
        public string Name { get; set; }   
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public string Code { get; set; }
    }
}
