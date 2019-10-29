using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace App.WS
{
    /// <summary>
    /// Descrição resumida de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        /*
         O WebService vai receber os dados das pessoas
         */

        [WebMethod]
        public void ArmazenaPessoa(PessoaModel _pessoa)
        {
            /*PessoaModel p = new PessoaModel();
            
            p.id = id;
            p.nome = nome;
            p.sobrenome = sobrenome;
            p.endereco = endereco;
            p.email = email;
            p.nasc = nasc;*/
            
            /*fluxo para armazenar no banco de dados*/

        }
    }
}
