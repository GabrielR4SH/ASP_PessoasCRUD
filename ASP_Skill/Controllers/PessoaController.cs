using ASP_Skill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Skill.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarPessoa(PessoaViewModel data)
        {
            using (Conexao db = new Conexao())
            {
                Pessoa model = new Pessoa();
                foreach (var property in typeof(PessoaViewModel).GetProperties())
                {
                    var value = property.GetValue(data);
                    var modelProperty = typeof(Pessoa).GetProperty(property.Name);
                    if (modelProperty != null && value != null)
                    {
                        modelProperty.SetValue(model, value);
                    }
                }

                // Salvar o modelo no banco de dados
                db.Pessoa.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}