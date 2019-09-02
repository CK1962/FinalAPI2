using FosterCareAPI2.Core.Models;
using FosterCareAPI2.Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FosterCareAPI2.Infrastructure.Data
{
    public class HouseRepository : IHouseRepository
    {
        private readonly FosterAPIDbContext _dbContext;

        public HouseRepository(FosterAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<House> GetAll()
        {
            return _dbContext.House
                 .Include(c => c.Child)
                //  .Include(c => c.Appointments)
                .ToList();
        }


        public House Get(int id)
        {
            return _dbContext.House
                   .Include(c => c.House)
                 //  .Include(c => c.Appointments)
                 .SingleOrDefault(c => c.Id == id);
        }

        public House Add(House House)
        {
            _dbContext.House.Add(House);
            _dbContext.SaveChanges();
            return House;
        }

        public House Update(House updatedHouse)
        {
            var currentHouse = _dbContext.House.Find(updatedHouse.Id);
            if (currentHouse == null) return null;
            _dbContext.Entry(currentHouse)
                .CurrentValues
                .SetValues(updatedHouse);

            _dbContext.House.Update(currentHouse);
            _dbContext.SaveChanges();
            return currentHouse;
        }

        public void Remove(int id)
        {
            var houseToDelete = Get(id);

            // TODO: remove blog
            _dbContext.House.Remove(houseToDelete);
            _dbContext.SaveChanges();
        }
    }
}
