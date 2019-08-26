using System;
using System.Collections.Generic;
using FosterCareAPI2.Core.Models;

namespace FosterCareAPI.Core.Services
{
    interface IChildService
    {
        Child Add(Child newChild);
        Child Update(Child updatedChild);
        Child Get(int id);
        IEnumerable<Children> GetAll();
        void Remove(int id);
    }
}
