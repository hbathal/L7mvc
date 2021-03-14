//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- Create Course class
//with necessary properties and 
//Using DatabaseGenerated.None to use own CourseID instead of generated 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } //tinfo200:[2021-03-13-<hbathal>-dykstra1]-- type list for navigation property to edit entities
    }
}