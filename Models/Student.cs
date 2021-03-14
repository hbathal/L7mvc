//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- Create Student class
//with all properties and ID being primary key

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- type list for navigation property to edit entities


    }
}
