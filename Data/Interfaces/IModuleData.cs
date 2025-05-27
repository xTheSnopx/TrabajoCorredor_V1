﻿using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IModuleData : IBaseModelData<Module>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Module module);
    }
}
