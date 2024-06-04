using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class Patient
{
    [Required] public int IdPatient { get; set; }

    [Required, MaxLength(50)] public string FirstName { get; set; }

    [Required, MaxLength(50)] public string LastName { get; set; }

    [Required] public DateTime Birthdate { get; set; }
}