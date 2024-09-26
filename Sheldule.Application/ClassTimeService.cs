using Microsoft.EntityFrameworkCore;
using Sheldule.Application.IService;
using Sheldule.DataAccess.Model;
using Sheldule.DataAccess;

namespace Sheldule.Application;

public class ClassTimeService : Repo<ClassTime>
{
    private readonly SchelduleContext _context = new SchelduleContext();

    public ClassTimeService()
    {
      
    }

    public async Task<ClassTime> Create(ClassTime entity)
    {
        await _context.ClassTimes.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<List<ClassTime>> Search(int num)
    {
        return await _context.ClassTimes.Where(i=>i.Number == num).ToListAsync();
    }
    public async Task Delete(ClassTime entity)
    {
        var classtime = _context.ClassTimes.Find(entity.Id);

        _context.ClassTimes.Remove(classtime);
        await _context.SaveChangesAsync();
    }

    public async Task<ClassTime> GetById(ClassTime entity)
    {
        return await _context.ClassTimes.FindAsync(entity.Id);
    }


    public async Task<List<ClassTime>> GetList()
    {
        return await _context.ClassTimes.ToListAsync();
    }

    public async Task<ClassTime> Update(ClassTime entity)
    {
        var classTime = await _context.ClassTimes.FindAsync(entity.Id);
        if (classTime != null)
        {
            classTime.Number = entity.Number;
            classTime.StartTime = entity.StartTime;
            classTime.EndTime = entity.EndTime;
            await _context.SaveChangesAsync();
        }
        return classTime;
    }
}
