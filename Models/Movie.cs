using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MvcMovie.Models
{
    public class Movie
    {
        CultureInfo ptBR = new CultureInfo("pt-BR");

        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        
        // [Column(CultureInfo.GetCultureInfo)]
        [Column(TypeName = "decimal 18, 2")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}