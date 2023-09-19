﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository <T> where T : class
    {
        Task <T> GetByIdAsync (int id); // ıd dön bana 
        IQueryable<T> GetAll (Expression<Func <T, bool>> expression); // IQueryable dönünce veri tabanına direk gitmek bir tolist gibi metotlarla gider.
        IQueryable <T> Where (Expression<Func <T, bool>> expression);
        Task<bool> AnyAsync (Expression<Func <T, bool>> expression);
        Task AddAsync (T entity);
        Task AddRangeAsync (IEnumerable<T> entities);
        void Update (T entity);
        void Remove (T entity);
        void RemoveRange (IEnumerable<T> entities);
    }
}
