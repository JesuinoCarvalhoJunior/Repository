using App.Db.Interfaces;
using App.Db.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace App.Db.Abstract
{
    public abstract class Repository<T>: IRepository<T> where T: class, new()
    {
        #region Property
        public AppEntities Contexto { get; private set; }
        public DbSet<T> Entity { get; private set; }
        #endregion Property
        #region Constructs
        public Repository()
        {
            this.Contexto = new AppEntities();
            this.Entity = this.Contexto.Set<T>();
        }
        public Repository(AppEntities Contexto)
        {
            this.Contexto = Contexto;
            this.Entity = this.Contexto.Set<T>();
        }
        #endregion Constructs
        #region Insert
        public void Insert(T Entity)
        {
            this.Entity.Add(Entity);
        }
        #endregion Insert
        #region Add
        public void Add(T Entity)
        {
            this.Entity.Add(Entity);
            this.Save();
        }
        public void Add(IList<T> Entities)
        {
            foreach (T Entity in Entities)
            {
                this.Add(Entity);
            }
        }
        #endregion Add
        #region Edit
        public void Edit(T Entity)
        {            
            this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Modified;
            this.Save();
        }
        #endregion Edit
        #region Delete
        public bool Delete(T Entity)
        {
            bool _delete = false;
            if (Entity != null)
            {
                this.Entity.Remove(Entity);
                this.Save();
            }
            return _delete;
        }
        public bool Delete(params object[] Keys)
        {
            bool _delete = false;
            T Entity = this.Find(Keys);
            if (Entity != null)
            {
                _delete = this.Delete(Entity);                                
            }
            return _delete;
        }
        public void DeleteAll(IList<T> Entities)
        {
            if (Entities != null)
            {
                foreach (T Entity in Entities)
                {
                    this.Entity.Remove(Entity);                    
                }
                this.Save();
            }
        }
        #endregion Delete
        #region Find
        public T Find(params object[] Keys)
        {
            return this.Entity.Find(Keys);
        }
        public T Single(System.Linq.Expressions.Expression<Func<T, bool>> Where)
        {
            return this.Entity.Single<T>(Where);
        }
        #endregion Find
        #region Query
        public IQueryable<T> Query()
        {
            return this.Entity;
        }
        public IQueryable<T> Query(System.Linq.Expressions.Expression<Func<T, bool>> Where)
        {
            return this.Entity.Where(Where).AsQueryable<T>();
        }
        #endregion
        #region Create
        public T Create()
        {            
            return this.Entity.Create();          
        }
        #endregion Create
        #region Save
        public int Save()
        {
            return this.Contexto.SaveChanges();
        }
        #endregion Save
        #region Dispose
        public void Dispose()
        {            
            this.Entity = null;
            this.Contexto.Dispose();
            this.Contexto = null;
            GC.SuppressFinalize(this);
        }
        #endregion Dispose
    }
}
