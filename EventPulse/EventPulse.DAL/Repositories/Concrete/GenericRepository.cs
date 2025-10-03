﻿using EventPulse.DAL.DataContext;
using EventPulse.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
namespace EventPulse.DAL.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity !=null) 
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync(); 
        }

        public async Task UpdatedAsync(T entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }
    }
}
