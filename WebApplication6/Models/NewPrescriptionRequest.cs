using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class NewPrescriptionRequest
{
    [Required] public Patient Patient { get; set; }
    [Required] public Doctor Doctor { get; set; }
    [Required, MaxLength(10)] public List<Medicament> Medicaments { get; set; }
    [Required] public DateTime Date { get; set; }
    [Required] public DateTime DueDate { get; set; }
}