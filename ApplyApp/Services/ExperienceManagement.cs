using ApplyApp.Models;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class ExperienceManagement : IExperienceManagement
    {
        private CrmDbContext db;

        public ExperienceManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public List<Experience> FindExperienceByCandidate(int candidateId)
        {
            Candidate candidate = db.Candidates.Find(candidateId);
            return db.Experiences
                     .Where(exp => exp.Candidate == candidate)
                     .ToList();
        }

        public List<Experience> FindExperienceByHRManager(int hrManagerId)
        {
            HRManager hrManager = db.HRManagers.Find(hrManagerId);
            return db.Experiences
                     .Where(exp => exp.HRManager == hrManager)
                     .ToList();
        }
    }
}
