using ApplyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Options
{
    public class JobOfferOption
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
