using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EmployeeEntity
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Telephone { get; set; }
        public string Gender { get; set; }
        public DateTime AddmissionDate { get; set; }
        public decimal Salary { get; set; }
        public int IdOfficeBrach { get; set; }
        public string OfficeBrach { get; set; }

    }
}
