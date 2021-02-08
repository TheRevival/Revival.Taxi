using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly TaxiDbContext _db;

        public ClientService(TaxiDbContext db)
        {
            _db = db;
        }
    }
}
