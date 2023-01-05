using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services;
using Domain.Entities;

namespace Infrastructure.Services.Persistence.Db
{
    internal class Repository<T>
    {
        public void Save(T obj)
        {
            // TODO: Implement real CRUD Operations
            Debug.WriteLine($"Objeto do tipo {typeof(T).Name} salvo");                            
        }
    }
}
