using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.PersonDTO
{
    internal class PersonDTO : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        // public string Email { get; set; }
        // public int CountryId { get; set; }
        // public int NeighborhoodId { get; set; }
        // Navigation properties
        // public virtual Country Country { get; set; }
        // public IEnumerable<UserPerson> UserPersons { get; set; }
    }
}