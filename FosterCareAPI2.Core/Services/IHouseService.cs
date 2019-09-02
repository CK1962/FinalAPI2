using System;
using System.Collections.Generic;
using FosterCareAPI2.Core.Models;

namespace FosterCareAPI2.Core.Services
{
    public interface IHouseService
    {
        House Add(House newHouse);
        House Update(House updatedHouse);
        House Get(int id);
        IEnumerable<House> GetAll();
        void Remove(int id);
    }
}