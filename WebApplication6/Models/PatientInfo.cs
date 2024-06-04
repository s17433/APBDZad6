using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class PatientInfo
{
    [Required] public Patient Patient { get; set; }
    [Required] public List<PrescriptionsForPatientInfoRequest> Prescriptions { get; set; }
}