//sets variables

function init(){
    
    //inits the jquery components
    /*
    trafficLight = TrafficLight({
        div:'divTraffic'
    }); 
    
    dialog = Dialog({
        speed:200
    });
    */
    
    
    clock({
        id:'datetime'
    });

    gauge = Gauge({
        id: 'jGauge'
    });
    
}



function Autenticar() {
    var usuario = $("#textBoxUsuario").text();
    var password = $("#textBoxPassword").text();
    $.ajax(
     {
         Type: "POST",
         contentType: "application/json; charset=utf-8",
         url: "http://localhost:56870/WebServiceWA.asmx/AutenticarSocio",
         data: { 'pUsuario': '"+usuario+"', 'pPassword': '"+password+"'},
         success: function (msg) {
             alert('sí');
         }
     });
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