<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CinePapu.Registro" %>

<!DOCTYPE html>

<html lang="en">
<head>
	<title>Registro</title>
	<meta charset="UTF-8"/>
	<!--Hace responsive la pagina -->
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="img/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
<!--===============================================================================================-->
</head>
<body>
	
	<div class="limiter">
		<!--Imagen de la ventana de registro-->
		<div class="container-login100" style = " background-image: url('img/bg-01.jpg'); ">
			<div class="wrap-login100">
				<form class="login100-form validate-form" runat="server"> 
					<span class="login100-form-logo">
						<i class="zmdi zmdi-landscape"></i>
					</span>
				<!--Solo va a imprimir el texto (registro)-->
					<span class="login100-form-title p-b-34 p-t-27">
						Registrate
					</span>
				<!--Caja de texo que pide el nombre del usuario-->
					<div class="wrap-input100 validate-input" >
                        <asp:TextBox ID="txtusuario" runat="server" placeholder="Nombre del usuario" required="" class="input100" ></asp:TextBox>	
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>		
				<!--Caja de texto que pide el correo electronico-->
                    <div class="wrap-input100 validate-input" >
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" required="" class="input100" ></asp:TextBox>						
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>	
				<!--Caja de texto que te pide la contraseña-->
                    <div class="wrap-input100 validate-input" >
                        <asp:TextBox ID="txtContrasenia" runat="server" placeholder="Contraseña" required="" class="input100" TextMode="Password"></asp:TextBox>						
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>	
				<!--Es un mensje que aparece si le das clic en el boton registrar sin escribir los datos que se piden-->
                    <div id="alerta" runat="server">
                        <h5>!Llena todos los campos</h5>
                    </div>
				<!--Boton que registra al usuario-->
					<div class="container-login100-form-btn">
                        <asp:Button ID="Registrar" runat="server" Text="Registrarse"  class="login100-form-btn" OnClick="Registrar_Click" />
					</div>

					
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>

</body>
</html>
