using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class Medicament
{
    [Required] public int IdMedicament { get; set; }
    [Required, MaxLength(100)] public string Name { get; set; }
    [Required, MaxLength(150)] public string Description { get; set; }
    [Required, MaxLength(50)] public string Type { get; set; }
}