using ApplyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyApp.Services
{
    public interface IRequestManagement
    {
        List<Request> FindAllRequestByJobOffer(int jobOffer);
        List<Request> FindAllRequestByCandidate(int candidateId);  
    }
}
