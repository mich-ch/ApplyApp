using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Thesis { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HRManager HRManager { get; set; }
        public Candidate Candidate { get; set; }
    }
}
