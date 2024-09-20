namespace Sheldule.DataAccess.Model;

public class Week
{
    public int Id { get; set; }
    public int Number { get; set; } // Номер недели
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}