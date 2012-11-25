function clock(parameters) {
    if (parameters.id == undefined)
        alert('Missing id!');
    
    setInterval( function() {
        var datetime1 = new Date().toLocaleTimeString();
        var hours = new Date().getHours();
        var minutes = new Date().getMinutes();
        var seconds = new Date().getSeconds();
        var am_pm = 'am'
        if(hours>12){
            hours=hours-12;
            am_pm='pm';
        }
        else{
            am_pm='am';
        }
        
        
        if(hours<10){
            hours='0'+hours;
        }
        if(minutes<10){
            minutes='0'+minutes;
        }
        if(seconds<10){
             seconds='0'+seconds;
        }
        
        datetime1 = hours+":"+minutes+":"+seconds+" "+am_pm;
        $("#"+parameters.id).html(datetime1);
    },1000);
    
}


