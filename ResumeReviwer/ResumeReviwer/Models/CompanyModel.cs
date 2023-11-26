using System.ComponentModel.DataAnnotations;

namespace ResumeReviewer.Models    
{
    public class Company 
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "A name is required.")]
        public string Name {get; set;}
        
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email {get; set;}
        
        [Required(ErrorMessage = "A password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password {get; set;}

        public ICollection<Job> Jobs {get; set;}
    }
}
        



