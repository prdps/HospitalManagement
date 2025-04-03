namespace HospitalManagement.Model
{
public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public int RoomNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Qualifications { get; set; }
    public string MedicalID {get;set;}
    public string Experience { get; set; }
    public string Availability { get; set; }
    public string sheduleTime { get; set; } // Added Schedule property
    public TimeOnly ShiftInTime { get; set; } // Changed to TimeSpan to store only time
    public TimeOnly ShiftOutTime { get; set; } // Added Shift property
}
}