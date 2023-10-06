using Encapsulation_practics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Services
{
    internal class DoctorServices
    {
        public Doctor[] dostors { get; set; }

        public DoctorServices() 
        {
            dostors=GetAllDoctors();
        }
        private Doctor[] GetAllDoctors()
        {
            Doctor doctor1 = new()
            {
                Id = 1,
                Name = "Eli",
                SurName = "Kerimli",
                Address = "Sumqayit",
                Birthday = new(1978, 09, 12)
            };
            Doctor doctor2 = new()
            {
                Id = 2,
                Name = "Emin",
                SurName = "Memmedli",
                Address = "Nesimi",
                Birthday = new(1995, 10, 10)
            };
            Doctor doctor3 = new()
            {
                Id = 3,
                Name = "Azer",
                SurName = "Heshimov",
                Address = "Genclik",
                Birthday = new(1993, 11, 01)
            };
            Doctor doctor4 = new()
            {
                Id = 4,
                Name = "Nergiz",
                SurName = "Ceferova",
                Address = "Abbas Sehet 12.",
                Birthday = new(1987, 05, 05)
            };
            Doctor doctor5 = new()
            {
                Id = 5,
                Name = "Zeyvi",
                SurName = "Kerimova",
                Address = "Nizami",
                Birthday = new(1990, 01, 07)
            };


            return new Doctor[] { doctor1, doctor2, doctor3, doctor4, doctor5 };
        }


        public Doctor[] GetFilteredBirtdayDoctors(DateTime startDate, DateTime endDate)
        {

            return dostors.Where(m=>m.Birthday>startDate && m.Birthday<endDate).ToArray();

        }

    }
}

