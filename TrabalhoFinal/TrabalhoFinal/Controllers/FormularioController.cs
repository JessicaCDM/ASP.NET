using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.Repositorio;

namespace TrabalhoFinal.Controllers;

public class FormularioController : Controller
{
    private readonly iDBRepositorio _BaseDadosRepositorio;

    public FormularioController(iDBRepositorio baseDadosRepositorio)
    {
        _BaseDadosRepositorio = baseDadosRepositorio;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Submeter()
    {
        List<RegistoModel> registo = _BaseDadosRepositorio.GetAll();
        return View(registo);
    }
    public IActionResult Editar(int Id)
    {
        RegistoModel registo = _BaseDadosRepositorio.GetId(Id);
        return View(registo);
    }
    public ActionResult EditarSelecionado(int Id)
    {
        return RedirectToAction("Editar", "RegistoModel", new { id = Id });
    }
    public IActionResult ConfirmarApagar(int id)
    {
        RegistoModel registo = _BaseDadosRepositorio.GetId(id);
        return View(registo);
    }

    [HttpPost]
    public IActionResult Apagar(int id)
    {
        _BaseDadosRepositorio.Apagar(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Criar(RegistoModel registo)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _BaseDadosRepositorio.Adicionar(registo);
                TempData["MensagemSuccess"] = "Registo feito com sucesso";
                return RedirectToAction("Index");
            }
            return View("Index", registo);
        }
        
        catch (System.Exception erro) 
        {
            TempData["MensagemErro"] = $"Não foi possível fazer o registo. Erro: {erro.Message}";
            return RedirectToAction("Index");
        }
   
        
    }
    [HttpPost]
    public IActionResult Alterar(RegistoModel registo)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _BaseDadosRepositorio.Alterar(registo);
                TempData["MensagemSuccess"] = "Registo feito com sucesso";
                return RedirectToAction("Index");
            }
            return View("Index", registo);
        }

        catch (System.Exception erro)
        {
            TempData["MensagemErro"] = $"Não foi possível fazer o registo. Erro: {erro.Message}";
            return RedirectToAction("Index");
        }
    }
}