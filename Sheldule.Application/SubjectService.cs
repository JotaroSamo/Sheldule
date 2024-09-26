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
        private readonly SchelduleContext _schelduleContext;

        public SubjectService(SchelduleContext schelduleContext )
        {
            _schelduleContext = schelduleContext;
        }
        public async Task<Subject> Create(Subject entity)
        {
            if (entity is not null)
            {
                await _schelduleContext.Subjects.AddAsync(entity);
                await _schelduleContext.SaveChangesAsync();
                return entity;
            }

            return null;
        }

        public async Task Delete(Subject entity)
        {
            var subject = await _schelduleContext.Subjects.FindAsync(entity.Id);
            if (subject != null) 
            {
                _schelduleContext.Subjects.Remove(subject);
                await _schelduleContext.SaveChangesAsync();
            }

        }

        public async Task<Subject> GetById(Subject entity)
        {
            return await _schelduleContext.Subjects.FindAsync(entity.Id);
        }

        public async Task<List<Subject>> GetList()
        {
            return await _schelduleContext.Subjects.ToListAsync();
        }

        public async Task<Subject> Update(Subject entity)
        {
            var subject = await _schelduleContext.Subjects.FindAsync(entity.Id);
            if (subject != null)
            {
                subject.Name = entity.Name;
                await _schelduleContext.SaveChangesAsync();
            }
            return subject;
        }
    }
}
