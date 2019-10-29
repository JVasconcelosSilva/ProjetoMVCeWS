using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class Usuarios
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuarios()
        {
            int id = 1;
            listaUsuarios.Add(new UsuarioModel
            {
                id = id++,
                nome = "Jose Carlos",
                sobrenome = "Macoratti",
                endereco = "Rua Projetada , 100",
                email = "macoratti@yahoo.com",
                nascimento = Convert.ToDateTime("05/09/1975")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = id++,
                nome = "Jefferson Andre",
                sobrenome = "Ribeiro",
                endereco = "Rua Mirassol , 50",
                email = "jeffbol@bol.com.br",
                nascimento = Convert.ToDateTime("13/08/1992")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = id++,
                nome = "Janice Lima",
                sobrenome = "Morais",
                endereco = "Rua Peru , 10",
                email = "janielima@hotmail.com",
                nascimento = Convert.ToDateTime("15/07/1990")
            });
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.id == usuarioModelo.id)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(int Id)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuarios)
                if (_usuario.id == Id)
                    _usuarioModel = _usuario;

            return _usuarioModel;
        }

        public void DeletarUsuario(int Id)
        {
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.id == Id)
                {
                    listaUsuarios.Remove(_usuario);

                    break;
                }
            }
        }
    }
}