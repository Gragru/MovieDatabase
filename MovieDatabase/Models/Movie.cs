using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieDatabase.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Only positive lengths please")]
        public int Length { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Age Limit")]
        [Range(0, 18, ErrorMessage = "0-18 please")]
        public int AgeLimit { get; set; }

        [Range(0, 100, ErrorMessage = "0-100 please")]
        public int MetaScore { get; set; }

   
        public string LengthInHours
        {
            get
            {
                var hours = Length / 60;
                var minutes = Length - hours * 60;
                return $"{hours}:{minutes:00}";
            }
        }
    }

    public enum Genre
    {
        Drama,
        Horror,
        Comedy,
        [Display(Name="Drama Comedy")]
        DramaComedy,
        SciFi,
        Action,
        Adventure
    }


}