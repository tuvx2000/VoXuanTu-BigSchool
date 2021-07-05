    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoXuanTu_BigSchool1.Models.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            string dateString = Date + " " + Time;
            return DateTime.ParseExact(dateString,@"d/M/yyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }

    }
}