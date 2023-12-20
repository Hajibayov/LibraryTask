using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryTask.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public List<Book> Books { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public Order()
        {
            Books = new List<Book>();
        }
    }
}
