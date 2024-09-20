namespace Sheldule.DataAccess.Model;

public class Classroom
{
    public int Id { get; set; }
    public string Number { get; set; }
    public string Type { get; set; } // Лекционный, лабораторный и т.д.
}
