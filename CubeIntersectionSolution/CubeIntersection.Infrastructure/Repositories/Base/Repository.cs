using CubeIntersection.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CubeIntersection.Core.Repositories.Base.IRepository;

namespace CubeIntersection.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CubeIntersectionContext _cubeIntersectionContext;

        public Repository(CubeIntersectionContext cubeIntersectionContext)
        {
            _cubeIntersectionContext = cubeIntersectionContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _cubeIntersectionContext.Set<T>().AddAsync(entity);
            await _cubeIntersectionContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _cubeIntersectionContext.Set<T>().Remove(entity);
            await _cubeIntersectionContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _cubeIntersectionContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _cubeIntersectionContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}