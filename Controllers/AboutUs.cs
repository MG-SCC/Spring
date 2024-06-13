using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Spring.Controllers;

public class AboutUsController : Controller
{
    // 
    // GET: /AboutUs/
    public IActionResult Index()
    {
        return View();
    }
     
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}