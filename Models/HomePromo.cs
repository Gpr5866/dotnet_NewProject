using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_NewProject.Models
{
    public class modelHomePromo
    {
        public string ID {get; set;}
        public string Description { get; set;}
        public string PromoType {get;set;}
        [DataType(DataType.Date)]
        public DateTime DurationStartDate {get; set;}
        public string Store {get; set;}
        public string StoreName {get;set;}
    }
}