using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Base;

namespace Entity.Model
{
    public class User : BaseEntity
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required IEnumerable<RolUser> RolUsers { get; set; }
    }
}
