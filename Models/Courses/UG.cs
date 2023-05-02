using UniversityManagement.Models.Subjects;

namespace UniversityManagement.Models.Courses
{
    public class UG:Diploma
    {
        public List<Credit> Credit { get; set; }
    }
}
