using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeReviewer.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set;}
        [NotMapped]
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
        public DateTime ExpiryDate { get; set;} 
        public ICollection<Application> Applications { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
