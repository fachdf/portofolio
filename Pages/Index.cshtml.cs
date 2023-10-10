using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portofolio.Pages
{
    public class IndexModel : PageModel
    {
        public string? FullName { get; set; }
        public string? LinkedInUsername { get; set; }
        public int? YearsOfExperience { get; set; }
        public List<string>? Languanges { get; set; }
        public void OnGet()
        {
            FullName = "Fachri Dhia Fauzan";
            LinkedInUsername = "in/fachri-dhia-fauzan";
            YearsOfExperience = 1;
            Languanges = new List<string>
            {
                "English",
                "Bahasa Indonesia",
            };
        }


    }
}