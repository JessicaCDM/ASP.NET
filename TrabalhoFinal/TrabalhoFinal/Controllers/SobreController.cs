using Microsoft.AspNetCore.Mvc;

namespace TrabalhoFinal.Controllers;

public class SobreController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}