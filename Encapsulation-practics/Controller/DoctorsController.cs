using Encapsulation_practics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Controller
{
    internal class DoctorsController
    {
        private DoctorServices doctorServices;
        public DoctorsController() 
        {
            doctorServices = new DoctorServices();
        }
        public void GetFilteredBirtday()
        {
            DateTime startDate = new(1993, 05, 25);
            DateTime endDate = new(2002, 12, 15);
            var result=doctorServices.GetFilteredBirtdayDoctors(startDate,endDate);
            foreach(var doctor in result)
            {
                Console.WriteLine($"{doctor.Name}-{doctor.SurName}-{doctor.Id}");
            }
        }
    }
}
