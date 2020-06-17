using ApplyApp.Models;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class RequestManagement : IRequestManagement
    {
        private CrmDbContext db;

        public RequestManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public List<Request> FindAllRequestByJobOffer(int jobOfferId)
        {
            JobOffer jobOffer = db.JobOffers.Find(jobOfferId);
            return db.Requests
                     .Where(jobOf => jobOf.JobOffer == jobOffer)
                     .ToList();
        }

        public List<Request> FindAllRequestByCandidate(int candidateId)
        {
            Candidate candidate = db.Candidates.Find(candidateId);
            return db.Requests
                     .Where(can => can.Candidate == candidate)
                     .ToList();
        }
    }
}
