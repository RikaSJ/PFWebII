<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAgregar.aspx.cs" Inherits="CinePapu.AdminAgregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="AdministradorPag" runat="server">
    	<title>Agregar</title>
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

<body>
	
	<div class="limiter">
		<div class="container-login100" style = " background-image: url('img/bg-01.jpg'); ">
			<div class="wrap-login100">
				<form class="login100-form validate-form" runat="server"> 
					<span class="login100-form-logo">
						<i class="zmdi zmdi-landscape"></i>
					</span>

					<span class="login100-form-title p-b-34 p-t-27">
						Nueva pelicula					
					</span>

					<div class="wrap-input100">
                        <asp:TextBox ID="txtnombre" runat="server" placeholder="Nombre"  class="input100" ></asp:TextBox>
					</div>

					<div class="wrap-input100">
                        <asp:TextBox ID="txtdescripccion" runat="server"  placeholder="Descripccion"  class="input100"  ></asp:TextBox>
					</div>
                    <div class="wrap-input100">
                        <asp:TextBox ID="txtAutor" runat="server"  placeholder="Autor"  class="input100"  ></asp:TextBox>
					</div>
                    <div class="wrap-input100">
                        <asp:TextBox ID="txtAno" runat="server"  placeholder="Año"  class="input100"  ></asp:TextBox>
					</div>
                    <div class="wrap-input100" >
                        <select id="Tipos" runat="server">
                            <option>Ciencia ficcion</option>
                            <option>Terror</option>
                            <option>Comedia</option>
                            <option>Thriller</option>
                            <option>Accion</option>
                            <option>Aventura</option>
                            <option>Animada</option>
                            <option>Fantasia</option>
                            <option>Drama</option>
                            <option>Romanticas</option>
                    </select>                       
                    </div>
                     <div class="wrap-input100">
                        <asp:TextBox ID="txtUrlVideo" runat="server"  placeholder="Url del video"  class="input100"  ></asp:TextBox>
					</div>
                     <div class="wrap-input100">
                        <asp:TextBox ID="txtUrlImagen" runat="server"  placeholder="nombre de la imagen con la extencion"  class="input100"  ></asp:TextBox>
					</div>
                    <div id="alerta" runat="server">
                        <asp:Button ID="guardar" runat="server" Text="Guardar pelicula"  class="login100-form-btn" type="submit" OnClick="guardar_Click" />
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
</asp:Content>
