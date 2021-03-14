//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- Create Enrollment class
//with all properties and EnrollmentID being primary key

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-<hbathal>-dykstra1]--Grade property is enum for multiple options 
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //tinfo200:[2021-03-13-<hbathal>-dykstra1]-- ? indicates that property is nullable
        public Student Student { get; set; }
    }
}