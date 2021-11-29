using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsStore.Pages
{
    public class FAQModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Here are some frequently asked questions and answers.";
        }
    }
}
