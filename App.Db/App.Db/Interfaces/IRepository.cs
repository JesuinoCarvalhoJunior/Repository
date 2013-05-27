using App.Db.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace App.Db.Interfaces
{
    public interface IRepository<T>: IDisposable where T:class, new()
    {
        AppEntities Contexto { get; }
        DbSet<T> Entity { get; }
        void Add(T Entity);
        void Add(IList<T> Entities);
        void Edit(T Entity);
        void Edit(IList<T> Entities);
        bool Delete(T Entity);
        void Delete(IList<T> Entities);   
        void Insert(T Entity);
        void Insert(IList<T> Entities);        
        void Update(T Entity);
        void Update(IList<T> Entities);             
        void Remove(T Entity);
        void Remove(IList<T> Entities);
        T Find(params object[] Keys);
        T Single(System.Linq.Expressions.Expression<Func<T, bool>> Where);
        IQueryable<T> Query();
        IQueryable<T> Query(Expression<Func<T, bool>> Where);
        T Create();
        Int32 Save();
    }
}
