using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sheldule.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheldulePro.DataAccess
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            // Настройка таблицы
            builder.ToTable("Schedules");

            // Настройка первичного ключа
            builder.HasKey(s => s.Id);

            // Настройка свойств
            builder.Property(s => s.ClassTimeId)
                .IsRequired();

            builder.Property(s => s.SubjectId)
                .IsRequired();

            builder.Property(s => s.ClassroomId)
                .IsRequired();

            // Настройка отношений
            builder.HasMany(s => s.Group)
                .WithMany() // Если необходимо, вы можете указать конкретную сущность для отношения
                .UsingEntity(j => j.ToTable("ScheduleStudentGroups")); // Создайте промежуточную таблицу

            builder.HasMany(s => s.Teacher)
                .WithMany() // Укажите конкретную сущность для отношения
                .UsingEntity(j => j.ToTable("ScheduleTeachers")); // Создайте промежуточную таблицу

            builder.HasOne(s => s.ClassTime)
                .WithMany() // Укажите соответствующее отношение, если есть
                .HasForeignKey(s => s.ClassTimeId)
                .OnDelete(DeleteBehavior.Cascade); // Настройка поведения при удалении

            builder.HasOne(s => s.Subject)
                .WithMany() // Укажите соответствующее отношение, если есть
                .HasForeignKey(s => s.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Classroom)
                .WithMany() // Укажите соответствующее отношение, если есть
                .HasForeignKey(s => s.ClassroomId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Week)
                .WithMany() // Укажите соответствующее отношение, если есть
                .HasForeignKey(s => s.WeekId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
