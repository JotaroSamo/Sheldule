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
    public class WeekService : Repo<Week>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public WeekService()
        {
        }

        // Создание новой недели
        public async Task<Week> Create(Week entity)
        {
            await _context.Weeks.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Удаление недели
        public async Task Delete(Week entity)
        {
            var week = await _context.Weeks.FindAsync(entity.Id);
            if (week != null)
            {
                _context.Weeks.Remove(week);
                await _context.SaveChangesAsync();
            }
        }

        // Получение недели по идентификатору
        public async Task<Week> GetById(Week entity)
        {
            return await _context.Weeks
                .FirstOrDefaultAsync(w => w.Id ==entity.Id);
        }

        // Получение списка всех недель
        public async Task<List<Week>> GetList()
        {
            return await _context.Weeks.ToListAsync();
        }

        // Обновление существующей недели
        public async Task<Week> Update(Week entity)
        {
            var week = await _context.Weeks.FindAsync(entity.Id);
            if (week != null)
            {
                week.Number = entity.Number;
                week.StartDate = entity.StartDate;
                week.EndDate = entity.EndDate;
                await _context.SaveChangesAsync();
            }
            return week;
        }
    }
}
