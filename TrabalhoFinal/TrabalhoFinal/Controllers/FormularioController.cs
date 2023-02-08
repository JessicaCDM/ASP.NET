using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers;

public class FormularioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Submeter()
    {
        return View();
    }
    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult Apagar()
    {
        return View();
    }
    public IActionResult ConfirmarApagar()
    {
        return View();
    }
}