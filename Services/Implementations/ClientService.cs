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

        public Task CreateTripAsync(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Task CancelTripAsync(long tripId)
        {
            throw new System.NotImplementedException();
        }
    }
}
