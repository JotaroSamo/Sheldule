using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sheldule.Application.IService;
using Sheldule.DataAccess;
using Sheldule.DataAccess.Model;

namespace Sheldule.Application
{
    public class ClassroomService : Repo<Classroom>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public ClassroomService()
        {
           
        }

        public async Task<Classroom> Create(Classroom entity)
        {
            await _context.Classrooms.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(Classroom entity)
        {
            _context.Classrooms.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Classroom> GetById(Classroom entity)
        {
            return await _context.Classrooms.FindAsync(entity.Id);
        }

        public async Task<List<Classroom>> GetList()
        {
            return await _context.Classrooms.ToListAsync();
        }

        public async Task<Classroom> Update(Classroom entity)
        {
           var classsrom = await _context.Classrooms.FindAsync(entity.Id);
           classsrom.Number = entity.Number;
           classsrom.Type = entity.Type;
           await _context.SaveChangesAsync();
           return classsrom;    
        }
    }
}
