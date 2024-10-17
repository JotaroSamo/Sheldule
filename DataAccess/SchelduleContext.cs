using Microsoft.EntityFrameworkCore;
using Sheldule.DataAccess.Model;
using SheldulePro.DataAccess;

namespace Sheldule.DataAccess;

public class SchelduleContext: DbContext
{

    public SchelduleContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Scheldule;Trusted_Connection=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ScheduleConfiguration());

        // Примените другие конфигурации
    }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<ClassTime> ClassTimes { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Week> Weeks { get; set; }
}