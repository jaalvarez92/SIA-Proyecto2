function requestAjax(pMetodo, onSuccess, onError, pParametros) {
    jQuery.ajax({
        url: pMetodo,
        type: 'POST',
        data: JSON.stringify(pParametros),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: onSuccess,
        error: onError
    });
}
/*
$('#lnkCerrarSesion').click(function () {
    requestAjax('Principal.Master/CerrarSesion', logoutValido, errorGeneral,
        {
        }
    );
});

$('#login-cmdLogin').click(function () {
});


function logoutValido(data) {
    document.location.href="Views/Login.aspx"
}

*/
function errorGeneral(data) {
    alert("Lo sentimos, hubo un error");
    $(".ajax-loader").css('display', 'none');
}

function ChangeDateFormat(jsondate) {
    jsondate = jsondate.replace("/Date(", "").replace(")/", "");
    if (jsondate.indexOf("+") > 0) {
        jsondate = jsondate.substring(0, jsondate.indexOf("+"));
    }
    else if (jsondate.indexOf("-") > 0) {
        jsondate = jsondate.substring(0, jsondate.indexOf("-"));
    }

    var date = new Date(parseInt(jsondate, 10));
    var month = date.getMonth() + 1 < 10 ?
		"0" + (date.getMonth() + 1) : date.getMonth() + 1;
    var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
    return date.getFullYear() + "-" + month + "-" + currentDate;
}