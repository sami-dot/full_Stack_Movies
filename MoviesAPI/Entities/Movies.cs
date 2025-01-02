using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MoviesAPI.Entities;

public class Movie
{

    public int Id {get; set;}

    [Required]
    [StringLength(40)]
    public required string Name { get; set; }

    [Required]
    [Range(1, 100)]
    public required decimal Price { get; set; }

    [ValidateNever]
    //Navigation Property
    public Genre? Genre {get; set;}

    //Foriegn Key
    public int GenreId {get; set;}

    public DateOnly ReleaseDate { get; set; }
}
