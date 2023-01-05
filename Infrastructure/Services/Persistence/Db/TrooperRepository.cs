using Application.Services;
using Domain.Entities;

namespace Infrastructure.Services.Persistence.Db
{
    public class TrooperRepository : IPersistenceService<Trooper>  
    {
        public void Save(Trooper trooper)
        {
            var repository = new Repository<Trooper>();
            repository.Save(trooper);
        }
    }
}
