using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Domain.Interfaces.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task Create(TEntity entity);
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task SaveChanges();
    }
}
