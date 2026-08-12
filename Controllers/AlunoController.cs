using EscolaSimples.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscolaSimples.Controllers
{
    public class AlunoController : Controller
    {
        // GET 
        public IActionResult Criar()
        {
            return View();
        }
    
        // POST 
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            return Content($"Aluno '{aluno.Nome}' com matrícula '{aluno.Matricula}' recebido com sucesso!");
        
        }
    }
}

