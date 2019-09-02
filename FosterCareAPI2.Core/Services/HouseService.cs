using System;
using FosterCareAPI2.Core.Models;
using System.Collections.Generic;


namespace FosterCareAPI2.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IHouseRepository _houseRepository;

        // TODO: inject IHouseRepository
        public HouseService(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public House Add(House newHouse)
        {
            return _houseRepository.Add(newHouse);
        }

        public House Get(int id)
        {
            return _houseRepository.Get(id);
        }

        public IEnumerable<House> GetAll()
        {
            return _houseRepository.GetAll();
        }

        public void Remove(int id)
        {
            _houseRepository.Remove(id);
        }

        public House Update(House updatedHouse)
        {
            return _houseRepository.Update(updatedHouse);
        }
    }
}
