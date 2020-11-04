using CodingChallenge.Domain.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Domain
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        TEntity Insert(TEntity newEntity);

        TEntity GetById(int entityID);

        IEnumerable<TEntity> GetAll
            (int skip = 0, int count = 0);



        TEntity Update(TEntity entity);

        void Delete(int entityID);
    }
}
