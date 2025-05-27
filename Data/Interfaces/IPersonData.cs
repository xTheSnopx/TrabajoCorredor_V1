﻿using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    internal interface IPersonData : IBaseModelData<Person>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Person person);
    }
}
