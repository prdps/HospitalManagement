
using HospitalManagement.Model;

public class HospitalService
{
    public List<Patient> Patients { get; set; } = new();
    public List<Doctor> Doctors { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();

    public void AddPatient(Patient patient)
    {
        patient.Id = Patients.Count + 1;
        Patients.Add(patient);
    }

    public void AddDoctor(Doctor doctor)
    {
        doctor.Id = Doctors.Count + 1;
        Doctors.Add(doctor);
    }

    public void BookAppointment(Appointment appointment)
    {
        appointment.Id = Appointments.Count + 1;
        Appointments.Add(appointment);
    }
}
