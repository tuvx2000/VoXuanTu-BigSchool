    using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VoXuanTu_BigSchool1.Models.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            string dateString = Date + " " + Time;
            DateTime str = DateTime.ParseExact(dateString, "M/d/yyyy hh:mm",CultureInfo.InvariantCulture);
            return str;
        }

    }
}