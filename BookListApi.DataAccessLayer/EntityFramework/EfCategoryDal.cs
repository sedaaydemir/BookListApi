using BookListApi.DataAccessLayer.Abstract;
using BookListApi.DataAccessLayer.Context;
using BookListApi.DataAccessLayer.Repositories;
using BookListApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListApi.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }
    }
}
