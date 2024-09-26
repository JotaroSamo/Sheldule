using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sheldule.DataAccess.Enums;

namespace Sheldule.DataAccess.Model
{
    public class Schedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public StudentGroup Group { get; set; }
        public int ClassTimeId { get; set; }
        public ClassTime ClassTime { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public SubjectType SubjectType { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public DayOfWeekEnum DayOfWeek { get; set; }
        public int WeekId { get; set; }
        public Week Week { get; set; }

    }
}
