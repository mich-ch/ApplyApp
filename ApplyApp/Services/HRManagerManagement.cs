﻿using ApplyApp.Models;
using ApplyApp.Options;
using ApplyApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyApp.Services
{
    public class HRManagerManagement : IHRManagerManagement
    {
        private CrmDbContext db;

        public HRManagerManagement(CrmDbContext _db)
        {
            db = _db;
        }

        public HRManager CreateHRManager(HRManagerOption hrManagerOption)
        {
            HRManager hrManager = new HRManager
            {
                FirstName = hrManagerOption.FirstName,
                LastName = hrManagerOption.LastName,
                Password = hrManagerOption.Password,
                PhotoPath = hrManagerOption.PhotoPath,
                Username = hrManagerOption.Username
            };

            db.HRManagers.Add(hrManager);
            db.SaveChanges();

            return hrManager;
        }
        public JobOffer CreateJobOffer(JobOfferOption jobOfferOption)
        {
            HRManager hr = db.HRManagers.Find(jobOfferOption.HRManagerId);
            JobOffer jobOffer = new JobOffer
            {
                Category = jobOfferOption.Category,
                Company = jobOfferOption.Company,
                Description = jobOfferOption.Description,
                EndDate = jobOfferOption.EndDate,
                Location = jobOfferOption.Location,
                StartDate = jobOfferOption.StartDate,
                Title = jobOfferOption.Title,
                HRManager = hr,
                Requests = null,
                Skills = null,
                PhotoPath = jobOfferOption.PicturePath
            };

            db.JobOffers.Add(jobOffer);
            db.SaveChanges();

            return jobOffer;
        }
        public Experience CreateExperience(ExperienceOption experienceOption)
        {
            HRManager hr = db.HRManagers.Find(experienceOption.HRManagerId);
            Experience exp = new Experience
            {
                Department = experienceOption.Department,
                Description = experienceOption.Description,
                EndDate = experienceOption.EndDate,
                StartDate = experienceOption.StartDate,
                HRManager = hr,
                Title = experienceOption.Title
            };

            db.Experiences.Add(exp);
            db.SaveChanges();

            return exp;
        }
        public Education CreateEducation(EducationOption educationOption)
        {
            HRManager hr = db.HRManagers.Find(educationOption.HRManagerId);
            Education edu = new Education
            {
                Department = educationOption.Department,
                EndDate = educationOption.EndDate,
                StartDate = educationOption.StartDate,
                HRManager = hr,
                Thesis = educationOption.Thesis,
                Title = educationOption.Title
            };

            db.Educations.Add(edu);
            db.SaveChanges();

            return edu;
        }
        public Request CreateRequest(RequestOption reqOpt)
        {
            JobOffer job = db.JobOffers.Find(reqOpt.JobOfferId);
            Candidate cand = db.Candidates.Find(reqOpt.CandidateId);
            Request req = new Request
            {
                Answer = "Pending",
                JobOffer = job,
                Candidate = cand
            };

            db.Requests.Add(req);
            db.SaveChanges();

            return req;
        }
        public Request AcceptRequest(int requestId, string answer)
        {
            Request req = db.Requests.Find(requestId);
            if (answer == "Yes" || answer == "No")
                req.Answer = answer;

            db.SaveChanges();
            return req;
        }
        public Request RejectRequest(int requestId, string answer)
        {
            Request req = db.Requests.Find(requestId);
            if (answer == "Yes" || answer == "No")
                req.Answer = answer;

            db.SaveChanges();
            return req;
        }
        public List<Candidate> FindCandidateByUniversity(string university)
        {
            List<Education> edus = db.Educations.Include(educ => educ.Candidate).Where(educ => educ.Department == university && educ.Candidate != null).ToList();
            List<Candidate> candidates = new List<Candidate>();
            foreach (var edu in edus)
            {
                candidates.Add(edu.Candidate);
            }
            return candidates;
        }
        public List<Candidate> FindCandidateByFname(string candidateFName)
        {
            return db.Candidates.Where(can => can.FirstName == candidateFName).ToList();
        }
        public List<Candidate> FindCandidateByLname(string candidateLName)
        {
            return db.Candidates.Where(can => can.LastName == candidateLName).ToList();
        }
        public List<Candidate> FindCandidateBySkills(List<string> titlesSkill)
        {
            List<Skill> skills = null;
            List<Candidate> candidates = null;
            foreach (var titleskill in titlesSkill)
            {
                skills.Add(db.Skills.Where(skl => skl.Title == titleskill).FirstOrDefault());
            }
            foreach (var skill in skills)
            {
                candidates.Add(skill.Candidate);
            }
            
            return candidates;
        }
        public List<JobOffer> FindJobOfferByHRManager(int hrManagerId)
        {
            HRManager hr = db.HRManagers.Find(hrManagerId);
            return db.JobOffers.Include(jbO => jbO.HRManager).Where(job => job.HRManager == hr && job.HRManager != null).ToList();
        }

    }
}
