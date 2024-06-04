using System.ComponentModel.DataAnnotations;

namespace APBD_06.Model;

public class Doctor
{
    [Required] public int IdDoctor { get; set; }

    [Required, MaxLength(50)] public string FirstName { get; set; }

    [Required, MaxLength(50)] public string LastName { get; set; }

    [Required, MaxLength(50), EmailAddress] public string Email { get; set; }
}