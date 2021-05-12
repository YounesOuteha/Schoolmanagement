using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace schoolManagement.Models
{
    public class CoursesMetaData
    {
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        [Range (1, 8)]
        public int Credits { get; set; }
    }

    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {
        
    }
}