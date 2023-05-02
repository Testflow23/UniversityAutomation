namespace UniversityManagement.Models.Register
{
    public class College
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        private DateTime Establish { get; set; }
        public string Category { get; set; }  //graduate  under grauate
        private string DirecName { get; set; }
        public string RegNumber { get; set; }
    }
}
