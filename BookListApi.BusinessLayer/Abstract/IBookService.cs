using BookListApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListApi.BusinessLayer.Abstract
{
    public interface IBookService:IGenericService<Book>
    {
    }
}
