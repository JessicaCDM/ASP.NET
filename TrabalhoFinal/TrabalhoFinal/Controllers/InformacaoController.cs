using Microsoft.AspNetCore.Mvc;


namespace TrabalhoFinal.Controllers;

public class InformacaoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
