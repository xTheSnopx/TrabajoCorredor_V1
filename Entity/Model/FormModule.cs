using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Pivote Formulario-Módulo
    public class FormModule : Base.BaseEntity
    {
        public int FormId { get; set; }
        public int ModuleId { get; set; }
        public Form Form { get; set; }
        public Module Module { get; set; }
    }
    

    
}
