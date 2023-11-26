using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeReviewer.Models 
{
    public class Application 
    {
        public int Id {get; set;}
        public string Email {get; set;}
        [NotMapped]
        public IFormFile Resume {get; set;}
        [NotMapped]
        public IFormFile CoverLetter {get; set;}

        public int JobId {get; set;}
        public Job Job {get; set;}
    }
}