using ApplyApp.Models;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class SkillManagement : ISkillManagement
    {
        private CrmDbContext db;

        public SkillManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public List<Skill> FindSkillsByCandidate(int candidateId)
        {
            Candidate candidate = db.Candidates.Find(candidateId);
            return db.Skills
                     .Where(skl => skl.Candidate == candidate)
                     .ToList();
        }

    }
}
