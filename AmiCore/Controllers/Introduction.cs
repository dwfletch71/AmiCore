using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmiCore.Controllers
{
    public class Introduction : Controller
    {
        // 
        // GET: /Introduction/
        public IActionResult Index()
        {
            //run's the web page View>Introduction>Index
            return View();
        }
        //
        // GET: /Introduction/Welcome
        // System.Text.Encodings.Web
        public IActionResult Welcome(string userName, int numOfTime = 1)
        {
            //comeented out the original return of string concat with param details
            //return HtmlEncoder.Default.Encode($"Hello {userName}, number of times is {numOfTime}");
            ViewData["Name"] = "Hiya" + userName;
            ViewData["NumberOfTimes"] = numOfTime;

            return View();
        }
    }
}
