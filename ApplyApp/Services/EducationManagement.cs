using ApplyApp.Models;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class EducationManagement : IEducationManagement
    {
        private CrmDbContext db;

        public EducationManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public List<Education> FindEducationByCandidate(int candidateId)
        {
            Candidate candidate = db.Candidates.Find(candidateId);
            return db.Educations
                     .Where(edu => edu.Candidate == candidate)
                     .ToList();
        }

        public List<Education> FindEducationByHRMAnager(int hrMAnagerId)
        {
            HRManager hrmanager = db.HRManagers.Find(hrMAnagerId);
            return db.Educations
                     .Where(edu => edu.HRManager == hrmanager)
                     .ToList();
        }
    }
}
