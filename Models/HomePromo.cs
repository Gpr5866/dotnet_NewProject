using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace dotnet_NewProject.Models
{
    public class modelHomePromo
    {
        public string ID {get; set;}
        public string Description { get; set;}
        public string PromoType {get;set;}
        public int ValueType {get;set;}
        [DataType(DataType.Date)]
        public DateTime DurationStartDate {get; set;}
        [DataType(DataType.Date)]
        public DateTime DurationEndDate {get; set;}
        [NotMapped]
        public IFormFile HasilFile {get;set;}
        public string Store {get; set;}
        public string StoreName {get;set;}
    }
}