using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Net6Tut.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;
    // can use DisplayName() or Display(Name = "") Either one works the same
    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "Display must be between 1 and 100!!")]
    public int DisplayOrder { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
