using ApplyApp.Models;
using ApplyApp.Options;
using ApplyApp.Repository;
using ApplyApp.Services;
using System;
using System.Collections.Generic;

namespace ApplyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Candidate
                 Create: Candidate      ok
                         Skills         ok
                         Education      ok
                         Experience     ok
                         Request        ok

                 Functions:     FindJobOffersByTitle        ok
                                FindJobOffersByCompany      ok
                                FindJobOffersByLocation     ok
                                FindJobOffersByCategory     ok
            */

            using CrmDbContext db = new CrmDbContext();
            ICandidateManagement candMngr = new CandidateManagement(db);
            IHRManagerManagement hrMngr = new HRManagerManagement(db);
            ISkillManagement skillMngr = new SkillManagement(db);
            IEducationManagement eduMngr = new EducationManagement(db);
            IExperienceManagement expMngr = new ExperienceManagement(db);
            IJobOfferManagement jobMngr = new JobOfferManagement(db);

            CandidateOption hrOpt = new CandidateOption
            {
                FirstName = "Sasa",
                LastName = "Aba",
                Password = "admin",
                Username = "chrpinkgos",
                PhotoPath = "/mjd", 
                 CVPath = "/mkds"
            };

            ExperienceOption expOpt = new ExperienceOption
            {
                CandidateId = 2,
                Department = "TEE",
                Description = "Lorem fsd fsdjfsd bjksfbsf",
                Title = "Engineer",
                StartDate = new DateTime(2015, 12, 31),
                EndDate = new DateTime(2016, 12, 31),
                HRManagerId = 0
            };

            SkillOption skillOpt = new SkillOption
            {
                CandidateId = 2,
                HRManagerId = 0,
                Knowlegde = 98,
                Title = "HTML"
            };

            EducationOption eduOpt = new EducationOption
            {
                CandidateId = 2,
                Department = "UTH",
                HRManagerId = 0,
                Title = "Department",
                Thesis = "Prospects",
                StartDate = new DateTime(2015, 12, 31),
                EndDate = new DateTime(2016, 12, 31)
            };

            JobOfferOption jobOpt = new JobOfferOption
            {
                Category = "Hardware",
                Company = "SKAG",
                Description = "This Company is amazing",
                Location = "Los Angeles",
                Title = "Engineer",
                HRManagerId = 1,
                EndDate = new DateTime(2015, 12, 31),
                StartDate = new DateTime(2015, 12, 31)
            };

            RequestOption reqOpt = new RequestOption
            {
                CandidateId = 2,
                JobOfferId = 1
            };

            //HRManager hr = hrMngr.CreateHRManager(hrOpt);
            //Education edu = hrMngr.CreateEducation(eduOpt);
            //Experience exp = hrMngr.CreateExperience(expOpt);
            JobOffer job = hrMngr.CreateJobOffer(jobOpt);
            Request req = candMngr.CreateRequest(reqOpt);

            List<JobOffer> jobOffers = candMngr.FindJobOffersByCategory(jobOpt.Category);
            Request requestNew = hrMngr.AcceptRequest(1, "Yes");
            List<Candidate> cands = hrMngr.FindCandidateByUniversity("UTH");

            //Console.WriteLine(
            //          $"Id= {requestNew.Id} Answer= {requestNew.Answer} JobOffer= {requestNew.JobOffer.Title}");

            foreach (var cand in cands)
            {
                Console.WriteLine($"Id= {cand.Id} FName= {cand.FirstName} LastName= {cand.LastName}");

            }





            /*   HRManager
                 Create: HRManager      ok
                         Skills         ok
                         Education      ok
                         Experience     ok
                         Request        
                         JobOffer       ok
                         
                Functions:   AcceptRequest                  ok
                             RejectRequest                  ok
                             FindCandidateByUniversity      ok
                             FindCandidateByFname           ok
                             FindCandidateByLname           ok
                             FindCandidateBySkills          front
                             FindJobOfferByHRManager        ok
            */
        }
    }
}
