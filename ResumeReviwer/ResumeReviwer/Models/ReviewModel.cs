using System.ComponentModel.DataAnnotations;
namespace ResumeReviewer.Models
{
    public class Review 
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Message is required.")]
        public string Message {get; set;}
    }
}