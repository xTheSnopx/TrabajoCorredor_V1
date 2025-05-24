using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    // Clase Formulario
    public class Form : Base.BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<FormField> FormFields { get; set; }
    }
}