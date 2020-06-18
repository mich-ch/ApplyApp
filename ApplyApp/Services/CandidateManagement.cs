using ApplyApp.Models;
using ApplyApp.Options;
using ApplyApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class CandidateManagement : ICandidateManagement
    {
        private CrmDbContext db;

        public CandidateManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public Candidate CreateCandidate(CandidateOption candidateOption)
        {
            Candidate candidate = new Candidate
            {
                FirstName = candidateOption.FirstName,
                LastName = candidateOption.LastName,
                Password = candidateOption.Password,
                Username = candidateOption.Username,
                PhotoPath = candidateOption.PhotoPath,
                CVPath = candidateOption.CVPath
            };

            db.Candidates.Add(candidate);
            db.SaveChanges();

            return candidate;
        }

        public Request CreateRequest(RequestOption reqOpt)
        {
            JobOffer jobOffer = db.JobOffers.Find(reqOpt.JobOfferId);
            Candidate cand = db.Candidates.Find(reqOpt.CandidateId);
            Request request = new Request
            {
                Answer = "Pending",
                JobOffer = jobOffer,
                Candidate = cand
            };

            db.Requests.Add(request);
            db.SaveChanges();

            return request;
        }

        public Experience CreateExperience(ExperienceOption experienceOption)
        {
            Experience experience = new Experience
            {
                Title = experienceOption.Title,
                Department = experienceOption.Department,
                Description = experienceOption.Description,
                EndDate = experienceOption.EndDate,
                StartDate = experienceOption.StartDate
            };

            db.Experiences.Add(experience);
            db.SaveChanges();

            return experience;
        }

        public Skill CreateSkill(SkillOption skillOption)
        {
            Candidate candidate = db.Candidates.Find(skillOption.CandidateId);
            Skill skill = new Skill
            {
                Knowlegde = skillOption.Knowlegde,
                Title = skillOption.Title,
                Candidate = candidate
            };

            db.Skills.Add(skill);
            db.SaveChanges();

            return skill;
        }

        public Education CreateEducation(EducationOption educationOption)
        {
            Candidate cand = db.Candidates.Find(educationOption.CandidateId);
            Education education = new Education
            {
                Department = educationOption.Department,
                EndDate = educationOption.EndDate,
                StartDate = educationOption.StartDate,
                Thesis = educationOption.Thesis,
                Title = educationOption.Title,
                Candidate = cand
            };

            db.Educations.Add(education);
            db.SaveChanges();

            return education;
        }

        public List<JobOffer> FindJobOffersByTitle(string title)
        {
            return db.JobOffers
                     .Where(jobOf => jobOf.Title == title)
                     .ToList();
        }

        public List<JobOffer> FindJobOffersByCompany(string company)
        {
            return db.JobOffers
                     .Where(jobOf => jobOf.Company == company)
                     .ToList();
        }

        public List<JobOffer> FindJobOffersByLocation(string location)
        {
            return db.JobOffers
                     .Where(jobOf => jobOf.Location == location)
                     .ToList();
        }
        public List<JobOffer> FindJobOffersByCategory(string category)
        {
            return db.JobOffers
                     .Where(jobOf => jobOf.Category == category)
                     .ToList();
        }
    }
}
