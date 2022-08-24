using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Enrollment.Models
{
    public enum Department
    {
        CSE, EEE
    }

    public class Student
    {
        //ID property will become the primary key column of the database table 
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public Department? Department { get; set; }
        public string Semester { get; set; }
        public DateTime EnrollmentDate { get; set; }
        /* Enrollments property is a navigation property. 
         * Navigation properties hold other entities that are related to this entity */
        // Collection for one-to-many or many-to-many 
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}