using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Options
{
    public class EducationOption
    {
        public int HRManagerId { get; set; }
        public int CandidateId { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Thesis { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
