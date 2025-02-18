<%@ Page Language="vb" AutoEventWireup="false" Codebehind="sys_map.aspx.vb" Inherits="srx.sys_map" %>
<!DOCTYPE HTML>
<HTML>
	<HEAD>
		<title>ErrorPage</title>
		<!-- #include file ="html\MetaAndLinkStylesheet.html" -->
		<link rel="stylesheet" href="css/w3.css">
		<link rel="stylesheet" href="css/w3-colors-win8.css">
		<!--  Desktop Favicons  -->
		<link rel="icon" type="image/png" href="./images/favicon_96x96.ico" sizes="96x96">
		<style>
			.mapA { 
					POSITION: fixed; 					
					left: 30%;
					top: 30%;
					transform: translate(-50%,);
				}		
			.mapB { 
					POSITION: fixed; 					
					left: 45.6%;
					top: 30%;
					transform: translate(-50%,);
				}		
					
			.zoom:hover {
				-ms-transform: scale(1.2); /* IE 9 */
				-webkit-transform: scale(1.2); /* Safari 3-8 */
				transform: scale(1.2); 
			}

			.myhide {
				display: none;  			
			}

			.myshow:hover + .myhide {
				display: block;
  				color: red;
			}
		</style>
	</HEAD>	
	<!-- #include file ="html\BodyColor.html" -->		
	
		<%response.write("<a class='mapA zoom myshow w3-mobile' href='sys_references'><IMG style='WIDTH: 200px' src='./images/mapA.png'></a>")%>
			<div class="myhide">I am shown MapA.</div>
		<%response.write("<a class='mapB zoom myshow w3-mobile' href='sys_references'><IMG style='WIDTH: 200px' src='./images/mapB.png'></a>")%>
			<div class="myhide">I am shown MapB.</div>
			
	</body>
</HTML>
