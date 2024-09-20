namespace Sheldule.DataAccess.Model;

public class ClassTime
{
    public int Id { get; set; }
    public int Number { get; set; } // Номер пары
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}