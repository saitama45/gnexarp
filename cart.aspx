
<%@ Page CodeBehind="cart.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="srx.cart" %>
<!DOCTYPE html>
<html>
<head>
<title>EMS Shop</title>
<!-- #include file ="html\ShopMeta.html" -->
<style>
	.btnDelete {
		background-color: transparent;
		border: 2px solid red;
		color: red;
		padding: 5px 10px;
		border-radius: 5px;
	}

	.btnDelete:hover {
		background-color: red;
		color: white;
	}

	.btnUpdate {
		background-color: transparent;
		border: 2px solid #2196F3;
		color: #2196F3;
		padding: 5px 10px;		
		border-radius: 5px;		
	}

	.btnUpdate:hover {
		background-color: #2196F3;			
		color: white;
	}

	.img-responsive {		
		max-width: 100px;
		height: 100px;		
		border: 0;
	}
	
	.w3-table td, .w3-table th, .w3-table-all td, .w3-table-all th {
		vertical-align: middle !important; 
		
	}
</style>
</head>
<body>
	<!-- #include file ="html\ShopTopMenu.html" -->	
	
	<!--breadcrumbs-->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="sys_home"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Cart</li>
			</ol>
		</div>
	</div>
	<!--//breadcrumbs-->
	<!--cart-items-->
	<div class="cart-items">
		<div class="container">
			<h3 class="wow fadeInUp animated" data-wow-delay=".5s">My Cart(<asp:label id="lblTotalItemCart" runat="server"></asp:label>)</h3>
			
			<table class="w3-table-all w3-card-4 w3-centered">
				
				<tr class="w3-blue">
					<th></th>
					<th class="w3-left-align">Item</th>
					<th>SRP</th>
					<th>Quantity</th>
					<th>Total</th>
					<th></th>
				</tr>
								
				<span id="Div1" runat="server"></span>
			</table>	
			<br>
			<hr>		
			<asp:button id="btnContinueShop" runat="server" CssClass="w3-btn w3-border-0 w3-large w3-blue w3-left" Text="Continue Shopping"></asp:button>
			<asp:button id="btnCheckout" runat="server" CssClass="w3-btn w3-border-0 w3-large w3-deep-orange w3-left w3-margin-left" Text="Check Out"></asp:button>
			<label class="w3-xlarge w3-right">GRAND TOTAL:&emsp;&#8369;<asp:label id="lblTotalCartAmount" runat="server"></asp:label></label>
			
		</div>
		
	</div>
	<!--//cart-items-->	
	<br/>
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
	</script>
	<!--//smooth-scrolling-of-move-up-->
	<!--Bootstrap core JavaScript
    ================================================== -->
    <!--Placed at the end of the document so the pages load faster -->
	
    <script src="js/bootstrap.js"></script>
	<script src="https://smtpjs.com/v3/smtp.js"></script>
	<script>		

		const submitInputs = document.querySelectorAll('.btnDelete');
		const numButtons = submitInputs.length; // Count the number of <input type="submit"> elements on the page

		const txtQtyInputs = []; // array to hold references to the input fields

		for (let i = 1; i <= numButtons; i++) {
			const btnDelete = document.getElementById(`btnDelete${i}`);
			const btnUpdate = document.getElementById(`btnUpdate${i}`);
			const txtQty = document.getElementById(`txtQty${i}`);
			const lblSOH = document.getElementById(`lblSOH${i}`);

			// Get the total number of soh
			const soh = parseInt(lblSOH.textContent);

			// Set the maximum value for the input field
			txtQty.setAttribute('max', soh);
			
			const hey = txtQtyInputs.push(txtQty);

			if (btnDelete) {
				btnDelete.addEventListener("click", function(e) {					
					
					const isLocalhost = location.hostname === "localhost" || location.hostname === "127.0.0.1" || location.hostname === "";
					let url;

					// set the URL to redirect to
					if (isLocalhost) {
						url = "http://127.0.0.1/ems_shop/cart?&id=" + btnDelete.getAttribute("name") + "&FormAction=Delete";
					} else {
						url = "http://shop.mykey.ph/cart?&id=" + btnDelete.getAttribute("name") + "&FormAction=Delete";
					}					

					const confirmed = confirm("Are you sure you want to delete this item?");

					if (confirmed) {				
						// redirect the user to the URL
						window.location.href = url;
						form.submit(); // submit the form programmatically
					} else {
						// do nothing
						e.preventDefault();
					}
				});
			}

			if (btnUpdate) {
				btnUpdate.addEventListener("click", function(e) {
					// Get the value of txtQty
					const txtQtyValue = parseInt(txtQty.value);
					
					const isLocalhost = location.hostname === "localhost" || location.hostname === "127.0.0.1" || location.hostname === "";
					let url;

					// set the URL to redirect to
					if (isLocalhost) {
						url = "http://127.0.0.1/ems_shop/cart?&id=" + btnDelete.getAttribute("name") + "&FormAction=Update&Qty=" + txtQtyValue;
					} else {
						url = "http://shop.mykey.ph/cart?&id=" + btnDelete.getAttribute("name") + "&FormAction=Update&Qty=" + txtQtyValue;
					}										
					
					// redirect the user to the URL
					window.location.href = url;					
					form.submit(); // submit the form programmatically
					
				});
			}
		}

		txtQtyInputs.forEach(function(inputField) {
			inputField.setAttribute('inputmode', 'numeric');
			inputField.addEventListener('input', function(e) {

				const currentValue = inputField.value;
				const key = e.key; // get the key pressed by the user
				const soh = parseInt(inputField.getAttribute('max'));

				if ((isNaN(key) || key == " ") && key != "Backspace" && key != "Delete" && key != "ArrowLeft" && key != "ArrowRight" && key != "Enter") {
					e.preventDefault();
				}

				if (inputField.value > soh) {
					inputField.value = soh;
				}

				if (inputField.value < 1) {
					inputField.value = 1;
				}

				// Convert the value to a whole number without decimal places
				inputField.value = Math.floor(parseFloat(inputField.value));
				console.log(inputField.value);
			});
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
	
	<script>

		// Helper function to ensure compatibility with older browsers
		function createXMLHttpRequest() {
			if (window.XMLHttpRequest) {
				return new XMLHttpRequest();
			} else if (window.ActiveXObject) {
				return new ActiveXObject("Microsoft.XMLHTTP");
			}
		}

		function refreshCartTotals() {
			var xhr = createXMLHttpRequest();
			xhr.open("POST", "CartHandler.aspx/GetCartTotals", true);
			xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
			
			xhr.onreadystatechange = function() {
				if (xhr.readyState == 4) {
					if (xhr.status == 200) {
						var response = eval("(" + xhr.responseText + ")");
						document.getElementById("lblTotalItemCart").innerHTML = response.totalItemCount;
						document.getElementById("lblTotalCartAmount").innerHTML = response.totalAmount;
						
						var btnCheckout = document.getElementById("btnCheckout");
						if (parseFloat(response.totalAmount) > 0) {
							btnCheckout.style.display = "";
						} else {
							btnCheckout.style.display = "none";
						}
					} else {
						alert("Error updating cart totals");
					}
				}
			};
			
			xhr.send();
		}

		function refreshCartItems() {
			var xhr = createXMLHttpRequest();
			xhr.open("POST", "CartHandler.aspx/GetCartItems", true);
			xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
			
			xhr.onreadystatechange = function() {
				if (xhr.readyState == 4) {
					if (xhr.status == 200) {
						var items = eval("(" + xhr.responseText + ")");
						var cartHtml = "";
						var counter = 1;
						
						for (var i = 0; i < items.length; i++) {
							var item = items[i];
							cartHtml += "<tr>" +
								"<td>" +
								"<a href='item?&code=" + item.code + "&item=" + item.itemFullname + "' class='at-in'>" +
								"<img src='" + item.imagePath + "' class='img-responsive' alt=''>" +
								"</a>" +
								"</td>" +
								"<td class='w3-left-align'>" +
								"<a href='item?&code=" + item.code + "&item=" + item.itemFullname + "' class='at-in'>" +
								"<h5>" + item.itemFullname + "</h5>" +
								"<div class='clearfix'></div>" +
								"</a>" +
								"</td>" +
								"<td class='w3-center'>₱" + item.srpShow + "</td>" +
								"<td class='w3-center'>" +
								"<div class='quantity'>" +
								"<input id='txtQty" + counter + "' min='1' type='number' value='" + item.qty + "' " +
								"style='border:1px solid white;width: 110px;' " +
								"class='w3-padding w3-center w3-text-black w3-border-deep-orange w3-hover-border-blue'>" +
								"</div>" +
								"</td>" +
								"<td class='w3-center'>₱" + item.totalSrpShow + "</td>" +
								"<td class='w3-center'>" +
								"<input type='button' class='btnUpdate w3-margin' onclick='updateItem(\"" + item.id + "\", " + counter + ")' value='UPDATE'>" +
								"<input type='button' class='btnDelete' onclick='deleteItem(\"" + item.id + "\")' value='Remove'>" +
								"</td>" +
								"<div style='display:none'><label id='lblSOH" + counter + "'>" + item.soh + "</label></div>" +
								"<label id='lblQty" + counter + "' style='display:none'>" + item.qty + "</label>" +
								"</tr>";
							counter++;
						}
						
						document.getElementById("cartItems").innerHTML = cartHtml;
					} else {
						alert("Error refreshing cart items");
					}
				}
			};
			
			xhr.send();
		}

		function updateItem(id, counter) {
			var qty = document.getElementById("txtQty" + counter).value;
			var xhr = createXMLHttpRequest();
			xhr.open("POST", "CartHandler.aspx/UpdateCartItem", true);
			xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
			
			xhr.onreadystatechange = function() {
				if (xhr.readyState == 4) {
					if (xhr.status == 200) {
						refreshCartItems();
						refreshCartTotals();
					} else {
						alert("Error updating cart item");
					}
				}
			};
			
			xhr.send("id=" + id + "&qty=" + qty);
		}

		function deleteItem(id) {
			if (confirm("Are you sure you want to remove this item?")) {
				var xhr = createXMLHttpRequest();
				xhr.open("POST", "CartHandler.aspx/DeleteCartItem", true);
				xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
				
				xhr.onreadystatechange = function() {
					if (xhr.readyState == 4) {
						if (xhr.status == 200) {
							refreshCartItems();
							refreshCartTotals();
						} else {
							alert("Error removing cart item");
						}
					}
				};
				
				xhr.send("id=" + id);
			}
		}

		// Initialize cart on page load
		window.onload = function() {
			refreshCartItems();
			refreshCartTotals();
		};
	</script>
</body>
</html>