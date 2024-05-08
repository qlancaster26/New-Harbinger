using System.ComponentModel.DataAnnotations;
namespace StarWars.Models;
public class Character
{
    public int CharacterId {get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Name {get; set; } = string.Empty;

    [Required(ErrorMessage = "Species is required")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Species {get; set;} = string.Empty;

    [Required(ErrorMessage = "Affiliation is required")]
    [StringLength(50, ErrorMessage = "Affiliation cannot exceed 50 characters")]
    public string Affiliation {get; set;} = string.Empty; 
}