using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements.ModuleData
{
    public class ModuleData : BaseModelData<Module>, IModuleData
    {
        public ModuleData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool status)
        {
            var module = await _context.Set<Module>().FindAsync(id);
            if (module == null)
                return false;
            module.Status = status;
            _context.Entry(module).Property(u => u.Status).IsModified = true;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Module module)
        {
            var existingModule = await _context.Modules.FindAsync(module.Id);
            if (existingModule == null) return false;
            _context.Modules.Update(existingModule);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
