using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Pais
    public class Country : BaseEntity
    {
        // Propiedades de la clase Pais
            public string Name { get; set; }

            public ICollection<Department> Departments { get; set; }
        }

    }
