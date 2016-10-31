using System.ComponentModel.DataAnnotations;

namespace ContactBookApp.Data_Layer
{
    public partial class Contacts
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string Birthday { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string Street { get; set; }

        [StringLength(30)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string City { get; set; }
    }
}
