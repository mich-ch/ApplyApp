using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HRManager HRManager { get; set; }
        public Candidate Candidate { get; set; }
    }
}
