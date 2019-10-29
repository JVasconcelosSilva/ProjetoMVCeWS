using AppMVC.AppWS;
using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        private static Usuarios _usuarios = new Usuarios();

        public ActionResult Index()
        {
            return View(_usuarios.listaUsuarios);
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            _usuarios.CriaUsuario(_usuarioModel);
            return View();
        }

        public ViewResult DeletaUsuario(int id)
        {
            return View(_usuarios.GetUsuario(id));
        }

        [HttpPost, ActionName("DeletaUsuario")]
        public RedirectToRouteResult DeletaUsuario(int id, FormCollection collection)
        {
            _usuarios.DeletarUsuario(id);
            return RedirectToAction("Index");
        }

        public ViewResult AtualizaUsuario(int id)
        {
            return View(_usuarios.GetUsuario(id));
        }

        [HttpPost]
        public RedirectToRouteResult AtualizaUsuario(int id, UsuarioModel _usuarioModel)
        {
            _usuarios.AtualizaUsuario(_usuarioModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void GetPessoa(string id, string nome, string sobrenome, string endereco, string email, string nasc)
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
        }
    }
}