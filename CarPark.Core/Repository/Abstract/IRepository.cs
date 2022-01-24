using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

using System.Threading.Tasks;
using CarPark.Core.Models;

namespace CarPark.Core.Repository.Abstract
{
     public interface IRepository<TEntity> where TEntity :class ,new()
     {
         GetManyResult<TEntity> GetAll();
         Task<GetManyResult<TEntity>> GetAllAsync();

         GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);
         Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter);


         GetOneResult<TEntity> GetById(string Id);
         Task<GetOneResult<TEntity>> GetByIdAsyc(string Id);

         GetOneResult<TEntity> InsertOne(TEntity entity);
         Task<GetOneResult<TEntity>> InsertOneAsync(TEntity entity);
         GetManyResult<TEntity> InsertMany(ICollection<TEntity> entity);
         Task<GetManyResult<TEntity>> InsertManyAsync(ICollection<TEntity> entity);

        GetOneResult<TEntity> ReplaceOne(TEntity entity,string id);
        Task<GetOneResult<TEntity>> ReplaceOneAsync(TEntity entity,string id);


        /// <summary>
        /// DELETE 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        

        GetOneResult<TEntity> DeleteOne(Expression<Func<TEntity, bool>> filter);
        Task<GetOneResult<TEntity>> DeleteOneAsync(Expression<Func<TEntity, bool>> filter);
        GetOneResult<TEntity> DeleteById(string Id);
        Task<GetOneResult<TEntity>> DeleteByIdAsyc(string Id);
        void DeleteMany(Expression<Func<TEntity, bool>> filter);
        Task DeleteManyAsync(Expression<Func<TEntity, bool>> filter);

    }
}
