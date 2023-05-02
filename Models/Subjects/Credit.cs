using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models.Subjects
{
    public class Credit
    {
        [Key]
        public int Id { get; set; }

        public string DSA { get; }
        public string Copiler_Design {get;set;}
        public string Computer_Networks { get; set;}
        public string OS { get; set; }
        public string Tafl { get;set;}
        public string Human_Values { get; set;}

    }
}
