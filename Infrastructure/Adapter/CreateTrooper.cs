using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UserCases;
using Infrastructure.Services.Persistence.Db;

namespace Infrastructure.Adapters
{
    public class CreateTrooperAdapter
    {
        private CreateTrooper useCase { get; set; }
        public string TrooperName { get; set; }
        public void execute() 
        {
            this.useCase.addTrooper(TrooperName);
        
        }
        public CreateTrooperAdapter(string trooperName) 
        {
            var persistenceService = new TrooperRepository();
            this.TrooperName =  trooperName;
            this.useCase = new CreateTrooper(persistenceService);           
        }

    }
}
