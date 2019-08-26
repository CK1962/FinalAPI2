using System;
using FosterCareAPI2.Core.Models;
using System.Collections.Generic;

namespace FosterCareAPI2.Core.Services
{
    public class ChildService : IChildService
    {
        private readonly IChildRepository _childRepository;

        // TODO: inject IChildRepository
        public ChildService(IChildRepository ChildRepository)
        {
            _childRepository = ChildRepository;
        }

        public Child Add(Child newChild)
        {
            return _childRepository.Add(newChild);
        }

        public Child Get(int id)
        {
            return _childRepository.Get(id);
        }

        public IEnumerable<Children> GetAll()
        {
            return _childRepository.GetAll();
        }

        public void Remove(int id)
        {
            _childRepository.Remove(id);
        }

        public Child Update(Child updatedChild)
        {
            return _childRepository.Update(updatedChild);
        }
    }
}
