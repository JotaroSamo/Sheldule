using Sheldule.Application.IService;
using Sheldule.DataAccess.Model;
using Sheldule.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace SheldulePro.Application
{
    public class TeacherService : Repo<Teacher>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public TeacherService()
        {
        }

        // Создание нового учителя
        public async Task<Teacher> Create(Teacher entity)
        {
            await _context.Teachers.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Удаление учителя
        public async Task Delete(Teacher entity)
        {
            var teacher = await _context.Teachers.FindAsync(entity.Id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                await _context.SaveChangesAsync();
            }
        }

        // Получение учителя по идентификатору
        public async Task<Teacher> GetById(Teacher entity)
        {
            return await _context.Teachers
                .FirstOrDefaultAsync(t => t.Id == entity.Id);
        }

        // Получение списка всех учителей
        public async Task<List<Teacher>> GetList()
        {
            return await _context.Teachers.ToListAsync();
        }

        // Обновление существующего учителя
        public async Task<Teacher> Update(Teacher entity)
        {
            var teacher = await _context.Teachers.FindAsync(entity.Id);
            if (teacher != null)
            {
                teacher.Name = entity.Name;
                await _context.SaveChangesAsync();
            }
            return teacher;
        }
    }
}
