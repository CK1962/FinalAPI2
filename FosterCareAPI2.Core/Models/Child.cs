using System;
using System.Collections.Generic;

namespace FosterCareAPI2.Core.Models
{
    public class Child
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Dob { get; set; }

        public string MoveInDate { get; set; }

        public ICollection<House> Home { get; set; }

        //public ICollection<Appointment> Appts { get; set; }
    }
}