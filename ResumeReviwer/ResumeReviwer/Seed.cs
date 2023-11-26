using ResumeReviewer.Data;
using ResumeReviewer.Models;

namespace ResumeReviewer
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Companies.Any() && !dataContext.Reviews.Any())
            {
                var companies = new List<Company>()
                {
                    new Company()
                    {
                        Name = "The Good Company",
                        Email = "nelson.ly41@gmail.com",
                        Password = "1stGamer",
                        Jobs =
                        {
                            new Job { Name = "Engineer", Description = "Engineer needed for this company", Status = Status.Ongoing, CreatedDate = DateTime.Now, ExpiryDate = new DateTime(2025, 12, 12) },
                            new Job { Name = "Engineer", Description = "Engineer needed for this company", Status = Status.Ongoing, CreatedDate = DateTime.Now, ExpiryDate = new DateTime(2025, 12, 12), Applications = { new Application {Email = "nelsonlynelson@gmail.com"} } }
                        }
                    }

                };
                dataContext.Companies.AddRange(companies);
          
                var reviews = new List<Review>()
                {
                    new Review() { Message = "Length: Should be at most 1 page" },
                    new Review() { Message = "Content: Is not relevant to job" }
                };

                dataContext.AddRange(reviews);

                dataContext.SaveChanges();
            }
        }
    }
}
