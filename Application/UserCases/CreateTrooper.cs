using Application.Services;
using Domain.Entities;
using Domain.UseCases;

namespace Application.UserCases
{
    public class CreateTrooper : ICreateTrooper
    {
        
        public IPersistenceService<Trooper> PersistenceService { get; set; }

        public CreateTrooper(IPersistenceService<Trooper> service)
        {
            this.PersistenceService = service;
        }
        public void addTrooper(string trooperName)
        {
            var trooper = new Trooper();
            trooper.Name = trooperName;
            PersistenceService.Save(trooper);
        }
    }
}
