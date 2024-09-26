using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Sheldule.Application.IService;
using Sheldule.DataAccess;
using Sheldule.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheldule.Application
{
    public class SubjectService : Repo<Subject>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public SubjectService()
        {

        }
        public async Task<List<Subject>> SearchByName(string name)
        {
            return _context.Subjects.Where(x => x.Name.Contains(name)).ToList();
        }
        public async Task<Subject> Create(Subject entity)
        {
            if (entity is not null)
            {
                await _context.Subjects.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            return null;
        }

        public async Task Delete(Subject entity)
        {
            var subject = await _context.Subjects.FindAsync(entity.Id);
            if (subject != null) 
            {
                _context.Subjects.Remove(subject);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<Subject> GetById(Subject entity)
        {
            return await _context.Subjects.FindAsync(entity.Id);
        }

        public async Task<List<Subject>> GetList()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<Subject> Update(Subject entity)
        {
            var subject = await _context.Subjects.FindAsync(entity.Id);
            if (subject != null)
            {
                subject.Name = entity.Name;
                await _context.SaveChangesAsync();
            }
            return subject;
        }
    }
}
