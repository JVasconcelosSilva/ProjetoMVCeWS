function salvarPessoa() {
            var id = document.getElementById("id").value;
            var nome = document.getElementById("nome").value;
            var sobrenome = document.getElementById("sobrenome").value;
            var endereco = document.getElementById("endereco").value;
            var email = document.getElementById("email").value;
            var nasc = document.getElementById("nasc").value;

            enviarPessoa(id, nome, sobrenome, endereco, email, nasc);
        }

    function enviarPessoa(id, nome, sobrenome, endereco, email, nasc) {
        $.post({
            url: '@Url.Action("GetPessoa", "Usuario")',
            data: { Id: id, Nome: nome, Sobrenome: sobrenome, Endereco: endereco, Email: email, Nasc: nasc },
            async: false
        }).done(function (e) {
            alert("Enviado com sucesso");
        }).fail(function() {
        alert( "error" );
        })

    }