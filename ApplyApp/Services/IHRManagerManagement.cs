using ApplyApp.Models;
using ApplyApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface IHRManagerManagement
    {
        HRManager CreateHRManager(HRManagerOption hrManagerOption);
        JobOffer CreateJobOffer(JobOfferOption jobOfferOption, int hrManagerId);
        Experience CreateExperience(ExperienceOption experienceOption, int HrManagerId);
        Education CreateEducation(EducationOption educationOption, int hrManagerId);
        Request CreateRequest(int candidateId, int JobOfferId);
        Request AcceptRequest(int requestId, string answer);
        public Request RejectRequest(int requestId, string answer);
        List<Candidate> FindCandidateByUniversity(string university);
        List<Candidate> FindCandidateByFname(string candidateFName);
        List<Candidate> FindCandidateByLname(string candidateLName);
        List<Candidate> FindCandidateBySkills(List<string> titlesSkill);
        List<JobOffer> FindJobOfferByHRManager(int hrManagerId);
    }
}
