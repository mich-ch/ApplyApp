using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class HRManager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string PhotoPath { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<JobOffer> JobOffers { get; set; }
    }
}
