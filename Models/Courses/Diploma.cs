using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using UniversityManagement.Models.Subjects;

namespace UniversityManagement.Models.Courses
{
    public class Diploma
    {
        [Key]
        public int DiplomaId { get; set; }

        public List<Basic> basic { get; set; }

    }
}
