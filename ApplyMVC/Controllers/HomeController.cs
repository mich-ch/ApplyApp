using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApplyMVC.Models;
using ApplyApp.Repository;
using ApplyApp.Services;

namespace ApplyMVC.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly CrmDbContext db;

        private ISkillManagement skillManagement;
        private IRequestManagement requestManagement;
        private IJobOfferManagement jobOfferManagement;
        private IHRManagerManagement hrManagerManagement;
        private IExperienceManagement experienceManagement;
        private IEducationManagement educationManagement;
        private ICandidateManagement candidateManagement;



        public HomeController(ILogger<HomeController> _logger, CrmDbContext _db,
                                ISkillManagement _skillManagement,
                                IRequestManagement _requestManagement,
                                IJobOfferManagement _jobOfferManagement,
                                IHRManagerManagement _hrManagerManagement,
                                IExperienceManagement _experienceManagement,
                                IEducationManagement _educationManagement,
                                ICandidateManagement _candidateManagement)
        {
            logger = _logger;
            db = _db;
            skillManagement = _skillManagement;
            requestManagement = _requestManagement;
            jobOfferManagement = _jobOfferManagement;
            hrManagerManagement = _hrManagerManagement;
            experienceManagement = _experienceManagement;
            educationManagement = _educationManagement;
            candidateManagement = _candidateManagement;
        }

        [HttpGet("")]
        public IActionResult Home()
        {
            return View("Index");
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
