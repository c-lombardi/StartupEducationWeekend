using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace StartupEducationWeekend.Models
{
    public class Colleges
    {
        [Key]
        public string CollegeId { get; set; }
        public string CollegeName { get; set; }
    }
}