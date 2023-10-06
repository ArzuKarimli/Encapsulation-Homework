using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Models
{
    internal class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

    }
}
