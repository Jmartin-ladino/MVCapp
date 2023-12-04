﻿using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCapp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string? Title { get; set; }
        [Display(Name = "ReleaseDate")]
        [DataType(DataType.Date)]
        public DateTime releaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        [Range(1,100)]
        [Required]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [StringLength(5)]

        public string Rating { get; set; }
    }
}