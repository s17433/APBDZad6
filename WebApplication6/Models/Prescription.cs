using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class Prescription
{
    [Required] public int IdPresription { get; set; }
    [Required] public DateTime Date { get; set; }
    [Required] public DateTime DueDate { get; set; }
    [Required] public int IdPatient { get; set; }
    [Required] public int IdDoctor { get; set; }
}