using System.ComponentModel.DataAnnotations;

namespace SecondRoundProject.Models.DTO
{
    public class RegistrationModel
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
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage ="Minimum length 6 and must contain 1 Uppercase, 1 Lowercase, 1 special character and 1 digit")] 
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        public string ? Role { get; set; }
    }
}
