//$("#update").click(function () {
//    var options = {};
//    options.url = "/api/customerservice/" 
//                  + $("#customerid").val();
//    options.type = "PUT";

//    var obj = {};
//    obj.customerID = $("#customerid").val();
//    obj.companyName = $("#companyname").val();
//    obj.contactName = $("#contactname").val();
//    obj.country = $("#country").val();

//    options.data = JSON.stringify(obj);
//    options.contentType = "application/json";
//    options.dataType = "html";
//    options.success = function (msg) {
//        $("#msg").html(msg);
//    };
//    options.error = function (a, b, c) {
//        alert(c);
//        $("#msg").html("Error while 
//                  calling the Web API!");
//    };
//    $.ajax(options);
//});