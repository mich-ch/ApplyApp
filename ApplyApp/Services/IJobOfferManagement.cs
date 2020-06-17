using ApplyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface IJobOfferManagement
    {
        List<JobOffer> FindAllJobOffer();
    }
}
