<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CinePapu.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
	<title>Inicio Sesion</title>
	<meta charset="UTF-8"/>
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
	<!--Imagen que se muestra en el Login-->
	<div class="limiter">
		<div class="container-login100" style = " background-image: url('img/bg-01.jpg'); ">
			<div class="wrap-login100">
				<form class="login100-form validate-form" runat="server" method="post"> 
					<span class="login100-form-logo">
						<i class="zmdi zmdi-landscape"></i>
					</span>
				<!--Solo es una etiqueta que dice iniciar sesion-->
					<span class="login100-form-title p-b-34 p-t-27">
						Iniciar sesion
					</span>
				<!--Un cuadro de texto para colocar el usuario -->
					<div class="wrap-input100">
                        <asp:TextBox ID="txtusuario" runat="server" placeholder="Usuario"  class="input100" ></asp:TextBox>						
						<span class="focus-input100" data-placeholder="&#xf207;"></span>
					</div>
				<!--Un cuadro de texto para colocar la contraseña -->
					<div class="wrap-input100">
                        <asp:TextBox ID="txtcontrasenia" runat="server"  placeholder="Contraseñia"  class="input100" TextMode="Password" ></asp:TextBox>
						<span class="focus-input100" data-placeholder="&#xf191;"></span>
					</div>
				<!-- Es un recordatorio para que lleve los datos-->
					<!--<div class="contact100-form-checkbox">
                        <asp:CheckBox ID="recordarme" runat="server" />
						<input class="input-checkbox100" id="ckb1" type="checkbox" name="remember-me">
						<label class="label-checkbox100" for="ckb1">
							Remember me
						</label>
					</div>-->
					
				<!--Esto aparece si el usuario no es correcto-->
                    <div id="alerta" runat="server">
                        <h5>!Usuario incorrecto</h5>
                    </div>
					<!--Botones para el inicio de sesion o para registrarse -->
					<div class="container-login100-form-btn">
                        <asp:Button ID="Iniciar" runat="server" Text="Iniciar Sesion"  class="login100-form-btn"  OnClick="Iniciar_Click" />
                        <asp:Button ID="Registrar" runat="server" Text="Registrarse"  class="login100-form-btn" OnClick="Registrar_Click"/>
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
