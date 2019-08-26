using FosterCareAPI2.Core.Models;
using FosterCareAPI2.Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FosterCareAPI.Infrastructure.Data
{
    public class ChildRepository : IChildRepository
    {
        private readonly FosterAPIDbContext _dbContext;

        public ChildRepository(FosterAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Children> GetAll()
        {
            return _dbContext.Child
                // .Include(c => c.House)
                //  .Include(c => c.Appointments)
                .ToList();
        }


        public Child Get(int id)
        {
            return _dbContext.Child
                 //  .Include(c => c.House)
                 //  .Include(c => c.Appointments)
                 .SingleOrDefault(c => c.Id == id);
        }

        public Child Add(Child Child)
        {
            _dbContext.Child.Add(Children);
            _dbContext.SaveChanges();
            return Children;
        }

        public Child Update(Child updatedChild)
        {
            var currentChild = _dbContext.Child.Find(updatedChild.Id);
            if (currentChild == null) return null;
            _dbContext.Entry(currentChild)
                .CurrentValues
                .SetValues(updatedChild);

            _dbContext.Child.Update(currentChild);
            _dbContext.SaveChanges();
            return currentChild;
        }

        public void Remove(int id)
        {
            var childToDelete = Get(id);

            // TODO: remove blog
            _dbContext.Child.Remove(childToDelete);
            _dbContext.SaveChanges();
        }
    }
}
