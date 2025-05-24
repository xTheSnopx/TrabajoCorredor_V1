using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Módulo
    public class Module : Base.BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<FormModule> FormModules { get; set; }
    }
    

    
}
