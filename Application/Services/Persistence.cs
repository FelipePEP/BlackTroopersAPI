using Domain.Entities;

namespace Application.Services
{
    public interface IPersistenceService<T>
    { 
        public void Save(T data);
    }
}
