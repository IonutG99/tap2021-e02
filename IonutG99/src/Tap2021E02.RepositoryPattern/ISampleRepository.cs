﻿using System.Linq;

namespace Tap2021E02.RepositoryPattern
{
    public interface ISampleRepository
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

        void Delete<TEntity>(TEntity entity) where TEntity : class;

        void Update<TEntity>(TEntity entity) where TEntity : class;

        TEntity Insert<TEntity>(TEntity entity) where TEntity : class;

        void Save();
    }
}
