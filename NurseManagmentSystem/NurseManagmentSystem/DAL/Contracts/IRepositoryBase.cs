using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagmentSystem.DAL.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        List<TEntity> GetFiltered();
        List<TEntity> GetFilteredById(int id);
        TEntity GetById(int id);
        List<TEntity> GetNotifications(string userId);
        void ReadNotification(int notificationId, string userId);
        Boolean UniqueData(string value);
    }
}
