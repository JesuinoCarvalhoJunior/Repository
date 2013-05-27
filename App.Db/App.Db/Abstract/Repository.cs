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
        #region AutoCommit
        #region Add
        public void Add(T Entity)
        {
            this.Entity.Add(Entity);
            this.Save();
        }
        public void Add(IList<T> Entities)
        {
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Entity.Add(Entity);
                }
                this.Save();
            }
        }        
        #endregion Add
        #region Edit
        public void Edit(T Entity)
        {            
            this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Modified;
            this.Save();
        }
        public void Edit(IList<T> Entities)
        {
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Modified;                    
                }
                this.Save();
            }
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
                _delete = true;
            }
            return _delete;
        }
        public void Delete(IList<T> Entities)
        {            
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Deleted;
                }
                this.Save();
            }            
        }
        #endregion Delete
        #endregion AutoCommit
        #region ConfirmCommit
        #region Insert
        public void Insert(T Entity)
        {
            this.Entity.Add(Entity);
        }
        public void Insert(IList<T> Entities)
        {
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Entity.Add(Entity);
                }
            }
        }
        #endregion Insert
        #region Update
        public void Update(T Entity)
        {
            this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Modified;
        }
        public void Update(IList<T> Entities)
        {
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Contexto.Entry<T>(Entity).State = System.Data.EntityState.Modified;
                }
            }
        }
        #endregion Update
        #region Remove
        public void Remove(T Entity)
        {
            if (Entity != null)
            {
                this.Entity.Remove(Entity);                
            }            
        }
        public void Remove(IList<T> Entities)
        {
            if (Entities != null && Entities.Count() > 0)
            {
                foreach (T Entity in Entities)
                {
                    this.Entity.Remove(Entity);                    
                }                
            }
        }
        #endregion Remove
        #endregion ConfirmCommit
        #region Find
        public T Find(params object[] Keys)
        {
            return this.Entity.Find(Keys);
        }        
        #endregion Find
        #region Single
        public T Single(System.Linq.Expressions.Expression<Func<T, bool>> Where)
        {
            return this.Entity.SingleOrDefault<T>(Where);
        }
        #endregion Single
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
