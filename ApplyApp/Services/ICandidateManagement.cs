using ApplyApp.Models;
using ApplyApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface ICandidateManagement
    {
        Candidate CreateCandidate(CandidateOption candidateOption);
        Request CreateRequest(int jobOfferId, int candidateId);
        Experience CreateExperience(ExperienceOption experienceOption);
        Skill CreateSkill(SkillOption skillOption, int candidateId);
        Education CreateEducation(EducationOption educationOption, int candidateId);
        List<JobOffer> FindJobOffersByTitle(string title);
        List<JobOffer> FindJobOffersByCompany(string company);
        List<JobOffer> FindJobOffersByLocation(string location);
        List<JobOffer> FindJobOffersByCategory(string category);
    }
}
