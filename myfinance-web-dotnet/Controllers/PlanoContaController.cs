using Microsoft.AspNetCore.Mvc;
using myfinance_web_dotnet.Domain;
using myfinance_web_dotnet.Infrastructure;
using myfinance_web_dotnet.Models;
using myfinance_web_dotnet.Services;
using System.Diagnostics;

namespace myfinance_web_dotnet.Controllers
{
    [Route("[controller]")]
    public class PlanoContaController : Controller
    {

        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaService.ListarRegistros();
            return View();
        }

        [HttpGet]
        [HttpPost]
        [Route("Cadastro")]
        public IActionResult Cadastro(PlanoContaModel? planoContaModel)
        {
            if(planoContaModel != null && ModelState.IsValid)
            {
                var planoConta = new PlanoConta();
                planoConta.Id = planoContaModel.Id;
                planoConta.Nome = planoContaModel.Nome;
                planoConta.Tipo = planoContaModel.Tipo;
                _planoContaService.Salvar(planoConta);
            }
            return View();
        }
    }
}
