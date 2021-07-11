using VoXuanTu_BigSchool001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VoXuanTu_BigSchool001.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FurureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            string dateString = Date +" "+Time;
            DateTime date3 = DateTime.ParseExact(dateString, @"dd/M/yyyy HH:mm",
                System.Globalization.CultureInfo.InvariantCulture);

            return date3;
        }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
    }
}