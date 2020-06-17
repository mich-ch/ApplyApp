using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class Request
    {
        public int Id { get; set; }
        public Candidate Candidate { get; set; }
        public JobOffer JobOffer { get; set; }
        public string Answer { get; set; }
    }
}
