using fizbuzz_wysyl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace fizbuzz_wysyl.Pages
{
    public class WyszukiwaneModel : PageModel
    {
        public Wpis Wpis { get; set; }

        public void OnGet()
        {
            
            var JSON = HttpContext.Session.GetString("FizzBuzz");
            if(JSON!=null)
            Wpis = JsonConvert.DeserializeObject<Wpis>(JSON);
        }
    }
}
