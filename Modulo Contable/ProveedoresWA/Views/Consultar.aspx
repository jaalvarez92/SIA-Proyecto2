<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProveedoresWA.Controllers.Consultar.cs"
    Inherits="ProveedoresWA.Controllers.Consultar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Styles/Style2.css" type="text/css" />
    <link rel="stylesheet" href='../Styles/SkinBlack.css' type="text/css" />
    <link rel="stylesheet" href="../Styles/jcdev/trafficLight.css" />
    <link rel="stylesheet" href="../Styles/jcdev/dialog.css" />
    <link rel="stylesheet" href="../Styles/jcdev/jgauge.css" />
    <script type="text/javascript" src="../JS/jquery-1.4.2.min.js"></script>
    <script language="javascript" type="text/javascript" src="../JS/jGauge/jQueryRotate.min.js"></script>
    <script language="javascript" type="text/javascript" src="../JS/jGauge/jgauge-0.3.0.a3.js"></script>
    <script type="text/javascript" src="../JS/main.js"></script>
    <script type="text/javascript" src="../JS/clock.js"></script>
    <script type="text/javascript" src="../JS/gauge.js"></script>
    <script type="text/javascript" src="../JS/consultar.js"></script>
    
</head>
<body onload="init()">
    <div class="main">
        <table class="sectionsContainer" cellpadding="0" cellspacing="0">
            <tr>
                <td id="mainHeader" colspan="2">
                    <table>
                        <tr>
                            <td>
                                <img id="logo" src="/img/clock.png" />
                            </td>
                            <td id="tdLogo" colspan="2">
                                Sistema de AutoGestión de Proveedores
                            </td>
                        </tr>
                    </table>
                </td>
                <td id="mainClock">
                    <div id="datetime">
                    </div>
                </td>
            </tr>
            <tr>
                <td id="mainSep" colspan="3">
                </td>
            </tr>
            <tr>
                <td class="sectionContainer">
                    <table class="section" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="sectionHeader">
                                <img src="/img/barcode.png" class="sectionIcon"></img>
                                Datos del Proveedor
                            </td>
                        </tr>
                        <tr>
                            <td class="sectionContent">
                                Nombre de Usuario:
                                <br/>
                                <input type="text" id='textBoxUsuario' size="15" tabindex="1" onkeypress="Autenticar(event)"
                                    value="pamodi"/>
                                <br/>
                                Contraseña
                                <br/>
                                <input type="password" id='textBoxPassword' size="15" tabindex="1" onkeypress="Autenticar(event)"
                                    value="1"/>
                                <br/>
                                <div id="proveedor">
                                </div>
                                <br/>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="sectionContainer">
                    <table class="section" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="sectionHeader">
                                <img src="/img/gaugeicon.png" class="sectionIcon"></img>
                                Información del producto
                            </td>
                        </tr>
                        <tr>
                            <td class="sectionContent">
                                <table style="width: 100%">
                                    <tr>
                                        <td class="sectionOrderState">
                                            Stock Mínimo:
                                            <div id="stock_minimo">
                                                0
                                            </div>
                                        </td>
                                        <td class="sectionOrderState">
                                            Stock Máximo:
                                            <div id="stock_maximo">
                                                0
                                            </div>
                                        </td>
                                        <td class="sectionOrderState">
                                            Stock Actual:
                                            <div id="stock_actual">
                                                0
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <center>
                                                <div id="jGauge" class="jgauge">
                                                </div>
                                            </center>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="sectionContainer">
                    <table class="section" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="sectionHeader">
                                <img src="/img/lighticon.png" style="width: 10px;" class="sectionIcon"></img>
                                Datos de la Orden
                            </td>
                        </tr>
                        <tr>
                            <td class="sectionContent">
                                <table style="width: 100%">
                                    <tr>
                                        <td>
                                            <center>
                                                Fecha:
                                                <div id="Orden_Fecha">
                                                    01/01/0001
                                                </div>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <center>
                                                Valor
                                                <div id="Orden_Valor">
                                                    0.0000
                                                </div>
                                            </center>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="sectionContainer" colspan="2">
                    <table class="section" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="sectionHeader">
                                <img src="/img/task.png" class="sectionIcon"></img>
                                Órdenes de Compra: 
                            </td>
                        </tr>
                        <tr>
                            <td class="sectionContent2">
                                <div id="taskContainer">
                                    Por favor ingrese sus datos...
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="sectionContainer">
                    <table class="section" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="sectionHeader">
                                <img src="/img/clock.png" class="sectionIcon"></img>
                                Acciones
                            </td>
                        </tr>
                        <tr>
                            <td class="sectionContent2">
                                <table style="width: 100%">
                                    <tr>
                                        <td>
                                            <center>
                                                <div id="options">
                                                </div>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <center>
                                                <div id="orderButton">
                                                </div>
                                            </center>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
