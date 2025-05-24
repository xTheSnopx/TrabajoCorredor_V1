 using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    internal class Department : BaseEntity
    {
        // Propiedades de la clase Departamento

        public string Name { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }


        public ICollection<User> Users { get; set; } = new List<User>();


    }
}
