using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Services.Interfaces
{
    public interface IClientService
    {
        Task CreateTripAsync(Order order);
        Task CancelTripAsync(long tripId);
    }
}