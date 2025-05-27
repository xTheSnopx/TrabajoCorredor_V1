﻿using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements.PersonData
{
    public class PersonData : BaseModelData<Person>, IPersonData
    {
        public PersonData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var person = await _context.Set<Person>().FindAsync(id);
            if (person == null)
                return false;
            person.Status = active;
            _context.Entry(person).Property(p => p.Status).IsModified = true;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Person person)
        {
            var existingPerson = await _context.Persons.FindAsync(person.Id);
            if (existingPerson == null) return false;
            _context.Persons.Update(existingPerson);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
