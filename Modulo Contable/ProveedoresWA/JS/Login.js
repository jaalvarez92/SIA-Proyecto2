$("#dialog").dialog({
    autoOpen: false
});


function validarDatos() {
    var usuarioValido=$.trim($('#textBoxUsuario').val()).length>0;
    var passValido = $.trim($('#textBoxPassword').val()).length>0;
    return passValido&&usuarioValido;
}


$('#DivIngresar').click(function () {
    if (!validarDatos()) {
        alert("no");
        return;
    }
    $('#ajax-loader').css('display', 'block');
    requestAjax('Login.aspx/Autenticar', usuarioSuccess, usuarioError,
        {
            'pUsuario': $('#textBoxUsuario').val(),
            'pPassword': $('#textBoxPassword').val()
        }
    );
});

  //var re = new RegExp(document.demoMatch.regex.value);   if (document.demoMatch.subject.value.match(re)) {     alert("Successful match");   } else {     alert("No match");   } }

function usuarioSuccess(data) {
    $('#ajax-loader').css('display', 'none');
    if (data.d == null) {
        $('#login-error-msj').css('display', 'block');
    } else 
            moverALogin();
    
    //alert(data.d);
}


function moverALogin(data) {
    document.location.href = 'Consultar.aspx';
}

function usuarioError(data){
    alert("Lo sentimos, ha habido un error");
    $('#ajax-loader').css('display', 'none');
}

$('#textBoxUsuario').focus(function () {
    $('#login-error-msj').css("display", "none");
});

$('#textBoxPassword').focus(function () {
    $('#login-error-msj').css("display", "none");
});
