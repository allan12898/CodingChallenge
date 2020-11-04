using CodingChallenge.Domain;
using CodingChallenge.Domain.Models.Models;
using CodingChallenge.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Repository
{
    public class RepositoryBase<TEntity>
        : IRepository<TEntity> where TEntity : EntityBase
    {
        protected readonly CodingChallengeDbContext context;

        public RepositoryBase(CodingChallengeDbContext context)
        {
            this.context = context;
        }
        public void Delete(int entityID)
        {
            var entityToRemove = GetById(entityID);
            if (entityToRemove == null)
            {
                throw new Exception("Record not found");
            }
            this.context.Remove<TEntity>(entityToRemove);
            this.context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll(int skip = 0, int count = 0)
        {
            var result = this.context.Set<TEntity>()
                .AsNoTracking()
                .Skip(skip)
                .Take(count)
                .ToList();

            return result;
        }

        public TEntity GetById(int entityID)
        {
            var result = this.context.Find<TEntity>(entityID);

            return result;
        }

        public TEntity Insert(TEntity newEntity)
        {
            this.context.Set<TEntity>()
                .Add(newEntity);
            this.context.SaveChanges();

            return newEntity;
        }

        public TEntity Update(TEntity entity)
        {
            var oldEntity = this.context.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefault(c => c.Id == entity.Id);
            if (oldEntity == null)
            {
                throw new Exception("Record not found");
            }
            this.context.Update(entity);
            this.context.SaveChanges();
            return entity;
        }
    }
}
