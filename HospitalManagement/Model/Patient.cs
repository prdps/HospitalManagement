

namespace HospitalManagement.Model
{
    public class Patient
    {
          public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Contact { get; set; }
    public DateTime RegisteredOn { get; set; } = DateTime.Now;
    }
}