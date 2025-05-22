using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Base;

namespace Entity.Model
{
    public class Rol : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required IEnumerable<RolUser> RolUsers { get; set; } 
    }
}
