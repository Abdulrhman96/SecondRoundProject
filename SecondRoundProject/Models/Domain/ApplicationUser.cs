using Microsoft.AspNetCore.Identity;

namespace SecondRoundProject.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {

        public string FName { get; set; }
        public string ? ProfilePicture { get; set; }
    }
}
