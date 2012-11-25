/**
 * Initiates the gauge component.
 */
function Gauge(parameters){
    if (parameters.id == undefined)
        alert('Missing id!');
    
    
    var path = '/img/jGauge/';
    
    var myGauge = new jGauge();
    myGauge.id = parameters.id;
    myGauge.imagePath = path + 'gauge.png';
    myGauge.needle.imagePath = path + 'taco.png';
    myGauge.segmentStart = -225
    myGauge.segmentEnd = 45
    myGauge.width = 203;
    myGauge.height = 202;
    myGauge.needle.xOffset = 0;
    myGauge.needle.yOffset = 0;
    myGauge.label.yOffset = 55;
    myGauge.label.color = '#fff';
    myGauge.label.precision = 0; 
    myGauge.label.suffix = '%';
    myGauge.ticks.labelRadius = 65;
    myGauge.ticks.labelColor = '#fff';
    myGauge.ticks.color = 'rgba(0, 0, 0, 0)';
    myGauge.range.color = 'rgba(0, 0, 0, 0)';
    myGauge.setValue(100);
    myGauge.setValue(0);
    myGauge.init();
    return myGauge;
}


