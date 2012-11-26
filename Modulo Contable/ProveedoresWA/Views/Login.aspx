<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProveedoresWA.Controllers.Login.cs" Inherits="ProveedoresWA.Controllers.Login" %>
<html>
<head>
  <title>AutoGestión de Proveedores</title>
  <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
  <link rel="stylesheet" type="text/css" href="../Styles/main.css" />
  <link rel="stylesheet" type="text/css" href="../Styles/Style2.css" />
  <link rel="stylesheet" type="text/css" href="../Styles/SkinBlack.css" />
  <link rel="stylesheet" type="text/css" href="../Styles/jquery-ui-1.9.0.custom.css" />
  <script type="text/javascript" src="../JS/modernizr-1.5.min.js"></script>
</head>

<body >  
      <div class="main" style= " height:20%">
            <table class="sectionsContainer" cellpadding="0" cellspacing="0"  width="100%">
                <tr>
                    <td id="mainHeader" colspan="2">
                        Sistema de Autegestión de Proveedores
                    </td>
                    <td id="mainClock">
                        aqui va la hora
                    </td>
                </tr>
                </table>
      </div>
    
    <div style= "width:33%; margin-left: auto; margin-right:auto; height:60%; margin-bottom:auto;">

      <table class="sectionsContainer" cellpadding="0" cellspacing="0"  width="33%">
                
                <tr align="center">
                    
                    <td class="sectionContainer" align="center"  colspan="3" style="width:300px">
                        <table class="section" cellpadding="0" cellspacing="0">

                            <tr>
                                <td class="sectionHeader" >
                                    <img src="/img/login.png" alt="" class="sectionIcon"/>
                                    Inicio de Sesión
                                </td>
                            </tr>
                            <tr>
                                <td class="sectionContent">
                                    <table>
                                        <tr>
					                        <td>Nombre de Usuario:</td>
                                        </tr>
				                        <tr>
					                        <td><input type="text" id='textBoxUsuario' size="15" tabindex = "1" onkeypress="" value=""/> </td>
				                        </tr>
				                        <tr>
					                        <td>Contraseña:</td>
					                    </tr>
                                        <tr>
                                            <td><input type="password" id="textBoxPassword" size="17" tabindex = "1" onkeypress="" value=""/> </td>
				                        </tr>
                                        <tr>
                                            <td><div id="DivIngresar" class="task">Ingresar </div></td>
                                        </tr>
			                        </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    
                </tr>
            </table>
      
      </div>
      <div style= "margin-bottom:0px; height:20%">
      <p>Copyright &copy; Sistema de AutoGestión de Proveedores - InnoTech</p>
      </div>
       
  <script type="text/javascript" src="../JS/jquery-1.8.2.js"></script>
  <script type="text/javascript" src="../JS/jquery-ui-1.9.1.custom.min.js"></script>
  <script type="text/javascript" src="../JS/main.js"></script>
  <script  type="text/javascript" src="../JS/Login.js"></script>
</body>
</html>
