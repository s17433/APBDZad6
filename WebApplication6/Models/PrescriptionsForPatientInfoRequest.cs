namespace APBD_06.Model;

public class PrescriptionsForPatientInfoRequest
{
    public int IdPerscription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public List<Medicament> Medicaments { get; set; }
    public int IdDoctor { get; set; }
    public string DoctorFirstName { get; set; }
}