//sets variables
var idUsuario = 0;
var ordenes;



function init(){
    clock({
        id:'datetime'
    });

    gauge = Gauge({
        id: 'jGauge'
    });
    
}



function Autenticar(e) {
    if (e.keyCode == 13) {
        var usuario = $("#textBoxUsuario").val();
        var password = $("#textBoxPassword").val();
        requestAjax('Consultar.aspx/AutenticarSocio', procesarE, procesarEError,
        {
            'pUsuario': usuario,
            'pPassword': password
        });
    }
}


function procesarE(data) {
    //alert('hola');
    if (data.d != null){
        $('#proveedor').html(data.d[1]);
        $('#textBoxUsuario').attr('disabled', 'true');
        $('#textBoxPassword').attr('disabled', 'true');
        idUsuario = data.d[0];
        botonCerrarSesion();
        llenarOrdenes();
        
    }
    else
        $('#proveedor').html('Nombre de Usuario o contrase'+'\u00f1'+'a incorrecta.');
}



function llenarOrdenes() {
    requestAjax('Consultar.aspx/ObtenerOrdenesCompraAutomaticasXSocio', procesarE2, procesarEError2,
        {
            'pIdSocio': idUsuario
        });
}

function procesarEError(data) {
    $('#proveedor').html('Error de conexión');
}



function procesarE2(data) {
    if (data.d != null) {
        ordenes= data.d;
        var botones = '';
        for (i = 0; i != data.d.length; i++) {
            botones = botones + '<div id="button_orden_'+ordenes[i][1]+'" onclick="orden('+i+')" class="task">' +ordenes[i][2]+' </div>  '
        }
        $('#taskContainer').html(botones);    
    }
    
}

function orden(i) {
    $('#Orden_Fecha').html(ChangeDateFormat(ordenes[i][0]));
    $('#Orden_Valor').html(ordenes[i][6]);
    $('#stock_minimo').html(ordenes[i][5]);
    $('#stock_actual').html(ordenes[i][3]);
    $('#stock_maximo').html(ordenes[i][4]);
    gauge.setValue(ordenes[i][3] / ordenes[i][4] * 100);
    var boton = '<div id="button_cambiar_' + ordenes[i][1] + '" onclick="facturarOrden(' + ordenes[i][1] + ')" class="task">' + 'Facturar' + ' </div>  '
    $('#orderButton').html(boton);
}


function procesarEError2(data) {
    $('#proveedor').html('Error de conexión');
}


function limpiarCampos() {
    gauge.setValue(0);
    $('#Orden_Fecha').html('01/01/0001');
    $('#Orden_Valor').html(0);
    $('#stock_minimo').html(0);
    $('#stock_actual').html(0);
    $('#stock_maximo').html(0);
    $('#orderButton').html('');
}


function cerrarSesion() {
    limpiarCampos();
    $('#textBoxUsuario').attr('disabled', '');
    $('#textBoxPassword').attr('disabled', '');
    $("#textBoxUsuario").val('');
    $("#textBoxPassword").val('');
    $('#proveedor').html('');
    $('#options').html('');
    $('#taskContainer').html('Por favor ingrese sus datos...');
}



function facturarOrden(i) {
    limpiarCampos();
    llenarOrdenes();
} 


/**
 * Paints a task button in the div which
 * name follows the patter 'task_{id}'
 */
function botonCerrarSesion(){
         $('#options').html('<div id="button_cerrar_sesion" onclick="cerrarSesion()" class="task"> Cerrar Sesion </div>');
}
///**
// * Process the error of the Http Reqeuest
// */
//function processError(error){
//    var result=messages.message_error_unknown;
//    if (error != undefined){
//        result = messages.message_error_db_connection +'.<br></br>'+result.error+"<br></br>"+result.errordetail;
//    }
//    dialog.showError(result);
//}




///**
// * Gets the name of the employee specified in the textboxIdEmployee
// */    
//function getEmployee(e) {
//    if (e.keyCode == 13) {
//        resetValues();
//        code = $("#textboxIdEmployee").val();
//        GET(
//        {
//            url: getUrl(["employee",code]),
//            success: processEmployee,
//            error: processError
//        }
//        );
//            
//    }
//}



///**
// * Procees the result of the get request of getEmployee
// */
//function processEmployee(result){
//    if(result!= null){
//        if(result.state){
//            var result_aux = getResult(result,1);
//            var tmp = "";
//            if(result_aux.length == 1){
//                tmp = '<div class="employee">'+result_aux[0].nombre+'</div>';
//                error_employee = false;
//            }
//            else{
//                dialog.showError(messages.message_error_employee);
//                $('#employee').html("");
//                error_employee = true;
//            }
//            $('#employee').html(tmp);
//        }
//        else{
//            dialog.showError(messages.message_error_db_connection +'.<br></br>'+result.error+"<br></br>"+result.errordetail);
//            $('#employee').html("");
//            error_employee = true;
//        }
//    }
//    else{
//        dialog.showError(messages.message_error_glassfish);
//        $('#employee').html("");
//        error_employee = true;
//        
//    }
//    getTasks();
//}


///**
// * Gets the tasks of the order specified in the textboxOrder for an employee
// */

//function getTasks(){
//    code = $("#textboxIdEmployee").val();
//    order = $("#textboxOrder").val();
//    if(! error_employee){
//        GET(
//        {
//            url: getUrl(["tasks",code,order]),
//            success: processTasks,
//            error: processError,
//            divWait: 'taskContainer'
//        }
//        );
//    }
//}

///**
// * Moves the cursor from txtOrder to txtEmployee
// */
//function moveTaskCursor(e) {
//    if (e.keyCode == 13) {
//        $('#textboxIdEmployee').focus();
//   
//    }
//}



///**
// * Procees the result of the get request of getTasks
// */
//function processTasks(result){
//    if(result!=null){
//        tasks = getResult(result,1);
//        if(result.state){
//            var tmp1="";
//            if(tasks.length > 0){
//                $.each(tasks, 
//                    function(key, value){ 
//                        if (value.descripcion !=undefined){
//                            tmp1+= '<div id="task_'+value.operacion+'"> </div>';
//                            selectedTask=value.operacion;
//                        }
//                    });
//                  
//                getEfficiencyOrder();
//        
//                $('#taskContainer').html(tmp1);
//                $.each(tasks, function(key,value){
//                    paintTask({
//                        taskName: value.descripcion, 
//                        taskId: value.operacion
//                    });
//                } );        
//            }
//            else{
//                dialog.showError(messages.message_error_tasks);
//            }
//        }
//        else{
//            dialog.showError(messages.message_error_db_connection +'.<br></br>'+result.error+"<br></br>"+result.errordetail);
//            $('#taskContainer').html("");
//        }
//    }
//    else{
//        dialog.showError(messages.message_error_glassfish);
//        $('#taskContainer').html("");
//    }
//       
//}


///**
// * Reset the values for an employee
// */
//function resetValues(){
//    $("#time_standard").html(0+" "+messages.label_hours);
//    $("#time_real").html(0+" "+messages.label_hours);
//    $("#time_remaining").html(0+" "+messages.label_hours);
//    $('#Perc_Order').html(0 +'%');
//    $('#taskContainer').html("");
//    $('#employee').html("");
//    $("#taskButton").html("");
//    $('#options').html("");
//    trafficLight.turnOn(0);
//    gauge.setValue(0);
//    trafficLight.turnOff();
//}

///**
// * resets the values for a tasks
// */
//function resetTask(){
//    $("#time_standard").html(0+" "+messages.label_hours);
//    $("#time_real").html(0+" "+messages.label_hours);
//    $("#time_remaining").html(0+" "+messages.label_hours);
//    $("#taskButton").html("");
//   $('#options').html("");
//}