using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamPreparation.Models.FormBindings;
using FinalExamPreparation.Services.Interfaces;
using FinalExamPreparation.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamPreparation.Controllers
{
    public class RootController : Controller
    {
        public IAccountService AccountService { set; get; }
        public RootController(IAccountService accountService)
        {
            AccountService = accountService;
        }



        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("register")]
        public async Task<IActionResult> RegisterGet()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterPost([FromBody] RegisterRequest registerRequest)
        {

            return View();
        }

        
    }
}
