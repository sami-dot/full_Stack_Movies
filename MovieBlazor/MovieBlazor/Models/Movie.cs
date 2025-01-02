using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace MovieBlazor.Models;

public class Movie
{
    public int Id {get; set;}

    [Required(ErrorMessage = "Movie Name is required")]
    [StringLength(50)]
    public string? Name { get; set; }

     [Required(ErrorMessage = "Movie Name is required")]
     public int GenreId { get; set; }

     [ValidateNever]
     public Genre? genre { get; set; }

     [Range(1,100, ErrorMessage = "Price must be between 1 and 100")]

     public decimal Price { get; set; }

     public DateOnly ReleaseDate { get; set; }


}
