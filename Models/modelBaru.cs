using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_NewProject.Models
{
    public class modelBaru
    {
        public int ID {get; set;}
        public string Judul { get; set;}

        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}
        public string Genre {get;set;}
        public decimal Price {get; set;}
    }
}