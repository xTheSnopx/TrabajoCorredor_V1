﻿using Entity.Model.Base;

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
        public  string Email { get; set; }
        public  string Password { get; set; }
        public  IEnumerable<RolUser> RolUsers { get; set; }
    }
}
