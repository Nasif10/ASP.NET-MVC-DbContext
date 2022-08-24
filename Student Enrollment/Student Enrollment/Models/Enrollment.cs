using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Student_Enrollment.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // Primary Key 
        public int EnrollmentID { get; set; }
        // Foreign Key 
        public string CourseID { get; set; }
        // Foreign Key 
        public int StudentID { get; set; }
        // Nullable 
        public Grade? Grade { get; set; }
        // Refernce to the Entity of FK 
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}