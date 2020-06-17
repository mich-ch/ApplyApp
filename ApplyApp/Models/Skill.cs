using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public HRManager HRManager { get; set; }
        public Candidate Candidate { get; set; }
        public string Title { get; set; }
        public int Knowlegde { get; set; }
    }
}
