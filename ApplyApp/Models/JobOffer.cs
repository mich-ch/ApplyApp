using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public HRManager HRManager { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Request> Requests { get; set; }
        public string PhotoPath { get; set; }
    }
}
