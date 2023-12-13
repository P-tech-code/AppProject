using System.ComponentModel.DataAnnotations;

namespace LastestProject.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
