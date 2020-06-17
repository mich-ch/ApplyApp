using ApplyApp.Models;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class JobOfferManagement : IJobOfferManagement
    {
        private CrmDbContext db;

        public JobOfferManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public List<JobOffer> FindAllJobOffer()
        {
            return db.JobOffers.ToList();
        }
    }
}
