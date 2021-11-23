using Microsoft.EntityFrameworkCore;
using NurseManagmentSystem.DAL.Contracts;

using NurseManagmentSystem.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal AuthDBContext _applicationContext;
        internal DbSet<TEntity> dbset;

        public  RepositoryBase(AuthDBContext applicationContext)
        {
            this._applicationContext = applicationContext;
            this.dbset = applicationContext.Set<TEntity>();
        }
        public virtual void Create(TEntity entity)
        {
            dbset.Add(entity);
            _applicationContext.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            dbset.Remove(entity);
            _applicationContext.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            var l = dbset.Select(e => e).ToList();
            return l;
        }

        public virtual TEntity GetById(int id)
        {
            return dbset.Find(id);
        }

        public virtual List<TEntity> GetFiltered()
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntity> GetFilteredById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual List<TEntity> GetNotifications(string userId)
        {
            throw new NotImplementedException();
        }

        public virtual void ReadNotification(int notificationId, string userId)
        {
            throw new NotImplementedException();
        }

        public virtual bool UniqueData(string value, int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            dbset.Update(entity);
            _applicationContext.SaveChanges();
        }
    }
}
