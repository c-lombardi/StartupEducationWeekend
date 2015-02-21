using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StartupEducationWeekend.Models
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassTitle { get; set; }
        [Required]
        public string ClassCode { get; set; }
        [Required]
        public string ClassSection { get; set; }

        public ICollection<UserProfile> Users { get; set; }

        public Classes()
        {
            Users = new HashSet<UserProfile>();
        }
    }
}