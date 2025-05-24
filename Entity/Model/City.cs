using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Ciudad
    public class City : BaseEntity
    {
        // Propiedades de la clase Ciudad
        public string Name { get; set; }
        //ID Departartamento 
        public int DepartmentId { get; set; }

        // Cambiar el tipo de accesibilidad de Department a public para resolver CS0053
        public ICollection<Department> Departments { get; set; } = new List<Department>();



    }
}
