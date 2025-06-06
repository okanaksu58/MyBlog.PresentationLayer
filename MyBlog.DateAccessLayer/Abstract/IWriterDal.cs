﻿using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DateAccessLayer.Abstract
{
    public interface IWriterDal : IGenericDal<Writer>
    {
        int GetWriterCount();
    }
}
