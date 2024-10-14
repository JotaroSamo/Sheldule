using Sheldule.Application.IService;
using Sheldule.DataAccess.Model;
using Sheldule.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SheldulePro.Application
{
    public class StudentGroupService : Repo<StudentGroup>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public StudentGroupService()
        {
        }
        public async Task<List<StudentGroup>> Search(string name)
        {

            return await _context.StudentGroups
                                         .Where(i => i.Name.Contains(name))
                                         .ToListAsync();


        }
        // Создание новой группы студентов
        public async Task<StudentGroup> Create(StudentGroup entity)
        {
            await _context.StudentGroups.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Удаление группы студентов
        public async Task Delete(StudentGroup entity)
        {
            var group = await _context.StudentGroups.FindAsync(entity.Id);
            if (group != null)
            {
                _context.StudentGroups.Remove(group);
                await _context.SaveChangesAsync();
            }
        }

        // Получение группы студентов по идентификатору
        public async Task<StudentGroup> GetById(StudentGroup entity)
        {
            return await _context.StudentGroups
                .FirstOrDefaultAsync(g => g.Id == entity.Id);
        }

        // Получение списка всех групп студентов
        public async Task<List<StudentGroup>> GetList()
        {
            return await _context.StudentGroups.ToListAsync();
        }

        // Обновление существующей группы студентов
        public async Task<StudentGroup> Update(StudentGroup entity)
        {
            var group = await _context.StudentGroups.FindAsync(entity.Id);
            if (group != null)
            {
                group.Name = entity.Name;
                await _context.SaveChangesAsync();
            }
            return group;
        }
    }
}
