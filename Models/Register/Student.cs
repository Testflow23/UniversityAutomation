using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models.Register
{
    public class Student:College
    {
        
        public int? ID { get; set; }
        public DateTime Dob {  get; set; }
        public bool IsDisability { get; set; }
        public string FName { get; set; }
        public string Mname { get; set; }

    }
}
