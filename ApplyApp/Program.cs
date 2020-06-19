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


            //Console.WriteLine(
            //          $"Id= {job.Id} FName= {job.HRManager.FirstName} Title= {job.Title}");

            foreach (var jobOffer in jobOffers)
            {
                Console.WriteLine($"Id= {jobOffer.Id} FName= {jobOffer.HRManager.FirstName} Category= {jobOffer.Category}");

            }





            /*   HRManager
                 Create: HRManager      ok
                         Skills         ok
                         Education      ok
                         Experience     ok
                         Request        
                         JobOffer       ok
                         
                Functions:   AcceptRequest
                             RejectRequest
                             FindCandidateByUniversity
                             FindCandidateByFname
                             FindCandidateByLname
                             FindCandidateBySkills
                             FindJobOfferByHRManager
            */
        }
    }
}
