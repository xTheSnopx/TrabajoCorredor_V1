using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Empleado
    internal class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public int CountryId { get; set; }
        public int NeighborhoodId { get; set; }

        // Navigation properties
        public virtual Country Country { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }
    }
}
