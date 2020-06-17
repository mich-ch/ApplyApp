using ApplyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface IEducationManagement
    {
        List<Education> FindEducationByCandidate(int candidateId);
        List<Education> FindEducationByHRMAnager(int hrMAnagerId);
    }
}
