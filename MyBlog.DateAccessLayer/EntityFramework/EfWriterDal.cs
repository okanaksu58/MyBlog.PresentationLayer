using MyBlog.DateAccessLayer.Abstract;
using MyBlog.DateAccessLayer.Repositories;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DateAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public int GetWriterCount()
        {
            // yazar sayısını getiren sorgu
            return 0;
        }
    }
}
