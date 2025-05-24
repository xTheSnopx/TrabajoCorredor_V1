
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Cliente
    internal class Client : Person
    {
        public int CountryId { get; set; }
        public int NeighborhoodId { get; set; }
        public int EmployeeId { get; set; }
        // Navigation properties
        public virtual Country Country { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }
        public virtual Employee Employee { get; set; }
    }
    
}

