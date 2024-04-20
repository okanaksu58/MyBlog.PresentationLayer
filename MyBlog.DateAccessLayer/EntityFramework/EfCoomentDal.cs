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
    public class EfCoomentDal : GenericRepository<Comment>, ICommentDal
    {
    }
}
