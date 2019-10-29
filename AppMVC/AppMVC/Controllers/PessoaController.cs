using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppMVC.AppWS;
using System.Net;

namespace AppMVC.Controllers
{
    public class PessoaController : Controller
    {
        [HttpPost]
        public ActionResult GetPessoa(string id, string nome, string sobrenome, string endereco, string email, string nasc)
        {
            PessoaModel _pessoa = new PessoaModel();
            _pessoa.id = id;
            _pessoa.nome = nome;
            _pessoa.sobrenome = sobrenome;
            _pessoa.endereco = endereco;
            _pessoa.email = email;
            _pessoa.nasc = nasc;
            
            WebService _ws = new WebService();
            _ws.ArmazenaPessoa(_pessoa);
            return View();
        }
    }
}