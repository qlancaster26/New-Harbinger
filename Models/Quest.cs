using System.ComponentModel.DataAnnotations;
namespace StarWars.Models; 
public class Quest
{
    public int QuestId {get; set;}

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title {get; set;} = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    public string Description {get; set;} = string.Empty;

    [Required(ErrorMessage = "Type is required")]
    [StringLength(50, ErrorMessage = "Type cannot exceed 50 characters")]
    public string Type {get; set;} = string.Empty;
}