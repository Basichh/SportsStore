using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Pages
{
    public class IndexModel : PageModel
    {
       public string SearchTerm { get; set; }
        public void OnGet()
        {

        }
    }
}
