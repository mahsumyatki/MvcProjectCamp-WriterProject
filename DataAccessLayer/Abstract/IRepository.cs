﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> Find(Expression<Func<T, bool>> filter);
    }
}