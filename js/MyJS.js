// Get the Sidebar
var mySidebar = document.getElementById("mySidebar");
			
// Get the Main Page
var myMainPage = document.getElementById("main");

// Get the DIV with overlay effect
var overlayBg = document.getElementById("myOverlay");

$(document).ready(function() {
    $('#homeLink').click(function() {
        var homepage = localStorage.getItem('homepage');
        var href = homepage === 'POS' ? 'sys_posmenu' : 'sys_mobilemenu';
        
        $(this).attr('href', href);
    });
});

// Toggle between showing and hiding the sidebar, and add overlay effect
function w3_open() {
    if (mySidebar.style.display === 'block') {
        mySidebar.style.display = "none";
        mySidebar.style.width = "0";
        myMainPage.style.marginLeft = "0"; 
        overlayBg.style.display = "none";
    } else {
        mySidebar.style.display = 'block';
        mySidebar.style.width = "270px";
        myMainPage.style.marginLeft = "270px";                     
        // overlayBg.style.display = "block";
    }
}

// Close the sidebar with the close button
function w3_close() {
    mySidebar.style.display = "none";
    mySidebar.style.width = "0";
    myMainPage.style.marginLeft = "0"; 
    overlayBg.style.display = "none";
}

// Dropdown for Profiler / Logout
function DropdownProfiler() {
    var x = document.getElementById("profiler");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
    } else { 
        x.className = x.className.replace(" w3-show", "");
    }
};

// Dropdown for Notif
function DropdownNotif() {
    var x = document.getElementById("notif");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
    } else { 
        x.className = x.className.replace(" w3-show", "");
    }
};

// Fade Out Alert Panel
$(document).ready(function(){   
    $("#AlertSuccess").fadeOut(5000);    
});
// $(document).ready(function(){
//     $("#AlertSuccess").fadeTo("slow", 0.7);
//     $("#AlertSuccess").fadeOut(10000);    
// });

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
});

// Searching
$(document).ready(function() {
    $('#txtSearch').keydown(function(event) {
        if (event.keyCode === 13) { // 13 is the key code for "Enter" key
            event.preventDefault(); // Prevent form submission
            $('#btnSearch').click(); // Trigger the click event of btnSearch button
        }
    });
});

function searchButtonClick() {
    var searchValue = $('#txtSearch').val(); // Get the value from the txtSearch textbox
    // Perform your search logic here using the searchValue
    
    // Example: Display an alert with the search value
    // alert('You searched for: ' + searchValue);
}

// Function to Disable comma when typing
$('.numberOnly').on('input', function(event) {

    // Get the current value
    var currentValue = $(this).val();

    // Remove any non-numeric characters
    var newValue = currentValue.replace(/[^\d.]/g, '');
                    
    // Update the input value
    $(this).val(newValue);
});

// prevent users from Typing letters | Numbers only
$(document).ready(function() {
    // Get the total number of pages
    var totalPages = parseInt($('#lblPageTotal').text());

    // Set the maximum value for the input field
    $('#txtCurrentPage').attr('max', totalPages);

    $('#txtCurrentPage').attr('inputmode', 'numeric').on('keydown input', function(e) {
        var currentValue = parseInt($(this).val());
        // Allow the following keys: left arrow, right arrow, and enter
        if ([37, 39, 13, 46, 8].indexOf(e.keyCode) !== -1) {
            return;
        }
        
        // Only allow numeric keys
        if (e.keyCode < 48 || e.keyCode > 57) {
            e.preventDefault();
            return;
        }
        
        if (currentValue > totalPages) {
            $(this).val(totalPages);
        }

        if (currentValue === 0 || isNaN(currentValue)) {
            $(this).val(1);
        }
    });
});

// Accordion Function for SideBarMenu Navigation
document.addEventListener("DOMContentLoaded", function(event) { 


    var acc = document.getElementsByClassName("accordion");
    var panel = document.getElementsByClassName('panel');
    
    for (var i = 0; i < acc.length; i++) {
        acc[i].onclick = function() {
            var setClasses = !this.classList.contains('active');
            setClass(acc, 'active', 'remove');
            setClass(panel, 'w3-show', 'remove');
    
            if (setClasses) {
                this.classList.toggle("active");
                this.nextElementSibling.classList.toggle("w3-show");
            }
        }
    }
    
    function setClass(els, className, fnName) {
        for (var i = 0; i < els.length; i++) {
            els[i].classList[fnName](className);
        }
    }
    
    });

    function clickButton(e, btnSave){
        var evt = e ? e : window.event;
        var bt = document.getElementById(btnSave);
        if (bt){
            if (evt.keyCode == 13){
                    bt.click();
                    return false;
            }
        }
    };   

   // Hide Span if Zero in Notification icon
   $(document).ready(function(){   
        $("#lblCountNotif").filter(function(){
            return $(this).text().trim() === "0";
        }).hide();
    });
   

    $(document).ready(function() {
        $("td:contains('Edit')").each(function(index) {            
            $(this).html($(this).html().replace('Edit', '&#9999;&#65039;'));            
        });
        
        $("td:contains('Delete')").each(function(index) {            
            $(this).html($(this).html().replace('Delete', '&#10060;'));            
        });
        
        $("td:contains('Open')").each(function(index) {            
            $(this).html($(this).html().replace('Open', '&#128194;'));            
        });
    });
      
      
      