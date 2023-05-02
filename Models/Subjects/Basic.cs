using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models.Subjects
{
    public class Basic
    {
        [Key]
        public int Id { get; set; }

        public string English { get;set; }
        public string Hindi { get; set; }
        public string Japanese { get; set; }
        public string Maths { get; set; }
        public string History { get; set; }
        public string Geography {get; set; }
        public string GK { get; set; }
    }
}
