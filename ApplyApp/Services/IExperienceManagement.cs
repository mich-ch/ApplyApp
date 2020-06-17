using ApplyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface IExperienceManagement
    {
        List<Experience> FindExperienceByCandidate(int candidateId);
        List<Experience> FindExperienceByHRManager(int hrManagerId);
    }
}
