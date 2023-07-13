using Microsoft.EntityFrameworkCore;
using ParkingLot.Project.Backend.Domain.Entities;
using ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository;
using ParkingLot.Project.Backend.Infra.Context;

namespace ParkingLot.Project.Backend.Infra.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MainContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MainContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual async Task<TEntity> GetById(int id) => await _dbSet.FirstOrDefaultAsync(x => x.Id == id && !x.Deleted);

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> Query() => _dbSet.AsNoTracking();
    }
}
