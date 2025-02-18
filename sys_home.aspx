<%@ Page Language="vb" aspcompat="true" AutoEventWireup="false" Codebehind="sys_home.aspx.vb" Inherits="srx.sys_home" %>

<!DOCTYPE html>
<html>
<head>
<title>EMS Shop</title>
<!-- #include file ="html\ShopMeta.html" -->
</head>
<body>	
	<!-- #include file ="html\ShopTopMenu.html" -->
	<!--banner-->
	<div class="w3-content w3-display-container" style="max-width:100%;">
		<img class="mySlides" src="images/img_nature_wide.jpg" style="width:100%;height: 350px;">
		<img class="mySlides" src="images/img_snow_wide.jpg" style="width:100%;height: 350px;">
		<img class="mySlides" src="images/img_mountains_wide.jpg" style="width:100%;height: 350px;">
		<div class="w3-center w3-container w3-section w3-large w3-text-white w3-display-bottommiddle" style="width:100%">
		  <div class="w3-left w3-hover-text-khaki" onclick="plusDivs(-1)">&#10094;</div>
		  <div class="w3-right w3-hover-text-khaki" onclick="plusDivs(1)">&#10095;</div>
		  <span class="demo w3-transparent w3-hover-white" onclick="currentDiv(1)"></span>
		  <span class="demo w3-transparent w3-hover-white" onclick="currentDiv(2)"></span>
		  <span class="demo w3-transparent w3-hover-white" onclick="currentDiv(3)"></span>
		</div>
	  </div>
	  
	  <script>
		var slideIndex = 1;
		showDivs(slideIndex);		
		
		function plusDivs(n) {
			showDivs(slideIndex += n);
		}
		
		function currentDiv(n) {
			showDivs(slideIndex = n);
		}
		
		function showDivs(n) {
			var i;
			var x = document.getElementsByClassName("mySlides");
			var dots = document.getElementsByClassName("demo");
			if (n > x.length) {slideIndex = 1}
			if (n < 1) {slideIndex = x.length}
			for (i = 0; i < x.length; i++) {
			x[i].style.display = "none";  
			}
			for (i = 0; i < dots.length; i++) {
			dots[i].className = dots[i].className.replace(" w3-white", "");
			}
			x[slideIndex-1].style.display = "block";  
			dots[slideIndex-1].className += " w3-white";
		}

		var slideIndex = 0;
		carousel();
		function carousel() {
			var i;
			var x = document.getElementsByClassName("mySlides");
			for (i = 0; i < x.length; i++) {
				x[i].style.display = "none";  
			}
			slideIndex++;
			if (slideIndex > x.length) {slideIndex = 1}    
			x[slideIndex-1].style.display = "block";  
			setTimeout(carousel, 3000); // Change image every 2 seconds
		}
	  </script>		
	<!--//banner-->
	<!--new-->
	<div class="new">
		<div class="container">
			<div class="title-info wow fadeInUp animated" data-wow-delay=".5s">
				<h3 class="title">Promo <span>Items</span></h3>				
			</div>
			<div class="w3-row w3-mobile">
				<span id="Div1" runat="server"></span>				
			</div>			
		</div>
	</div>		
	<!--//new-->
	<!--gallery-->
	<div class="gallery">
		<div class="container">
			<div class="title-info wow fadeInUp animated" data-wow-delay=".5s">
				<h3 class="title">Select<span> Category</span></h3>
				<!-- <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit curabitur </p> -->
			</div>
			<div class="w3-row">
				<span id="Div2" runat="server"></span>				
			</div>
		</div>
	</div>
	<!--//gallery-->
	
	<!-- #include file ="html\ShopFooterMenu.html" -->
	
	<!--search jQuery-->
	<script src="js/main.js"></script>
	<!--//search jQuery-->
	<!--smooth-scrolling-of-move-up-->
	<script type="text/javascript">
		$(document).ready(function() {
		
			var defaults = {
				containerID: 'toTop', // fading element id
				containerHoverID: 'toTopHover', // fading element hover id
				scrollSpeed: 1200,
				easingType: 'linear' 
			};
			
			$().UItoTop({ easingType: 'easeOutQuart' });
			
		});

		$(function() {
			var form = $("#Form1");
			var searchBox = $("#txtSearch");

			searchBox.keypress(function(event) {
				if (event.keyCode === 13) { // 13 is the "Enter" key code
					event.preventDefault(); // prevent default form submission
					form.submit(); // submit the form programmatically
				}
			});
		});
	</script>	
	<!--//smooth-scrolling-of-move-up-->
	<!--Bootstrap core JavaScript
    ================================================== -->
    <!--Placed at the end of the document so the pages load faster -->
    <script src="js/bootstrap.js"></script>
</body>
</html>
