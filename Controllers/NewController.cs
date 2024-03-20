using Microsoft.AspNetCore.Mvc;
using System.IO;
namespace WIHTOUT_DOCK.Controllers
{
    public class NewController : Controller
    {
        //method to handle the request 
        public IActionResult Index()
        {
            //using System.IO; get the index.html if it is inside the wwwroot folder , else return the View()
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html");

            if (System.IO.File.Exists(filePath))
            {
                // Serve the file
                return PhysicalFile(filePath, "text/html");
            }
            return View();
            //ends the serving the file logic here(1)


        }
    }
}
