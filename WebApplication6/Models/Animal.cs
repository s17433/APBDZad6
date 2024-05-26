using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models;

public class Animal
{
    [Key]
    public int IdAnimal { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; }
    
}