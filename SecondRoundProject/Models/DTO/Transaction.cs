using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondRoundProject.Models.DTO
{
    public class Transaction
    {
        [Required]
        [StringLength(60)]
        //[RegularExpression("^[0-9A-Za-z!@.,;:'\"?-]{1,60}\\z", ErrorMessage = "Fisrt name should be less than 60 characters")]
        public string FName { get; set; }
        [Required]
        [StringLength(60)]
        // [RegularExpression("^[0-9A-Za-z!@.,;:'\"?-]{1,60}\\z", ErrorMessage = "Last name should be less than 60 characters")]
        public string LName { get; set; }
        [Required]
        [RegularExpression("\\b\\d{11}\\b", ErrorMessage = "ID should be exactly 11 characters")]
        public string ID { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Photo { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Username { get; set; }
       
    }
}
