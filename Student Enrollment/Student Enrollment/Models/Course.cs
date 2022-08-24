using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Enrollment.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        // Collection for one-to-many or many-to-many 
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}