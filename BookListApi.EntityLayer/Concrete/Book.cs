using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListApi.EntityLayer.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookImageUrl { get; set; }
        public string BookDescription { get; set; }
        public int BookStok { get; set; }
        public decimal BookPrice { get; set; }
    }
}
