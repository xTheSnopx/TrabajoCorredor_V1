using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Base;

namespace Entity.Model
{
    public class RolUser : BaseEntity
    {
        public int RolId { get; set; }
        public int UserId { get; set; }

        public required Rol Rol { get; set; }
        public required User User { get; set; }
    }
}
