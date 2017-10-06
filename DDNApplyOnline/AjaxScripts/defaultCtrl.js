function Subscribe() {
 
    var options = {};
    options.url = "http://localhost:53017/api/Default/Subscribe";
    options.type = "POST";

    var obj = {};
    obj.FirstName = $("#firstname").val();
    obj.LastName = $("#lastname").val();
    obj.EmailAddress = $("#email").val();


    obj.FkGenderId = $("#gender").val();

    options.data = JSON.stringify(obj);
    options.contentType = "application/json";
    options.dataType = "html";
    crossDomain: true;
    options.success = function (msg) {
        $("#msg").html(msg);
    };
    options.error = function () {
        $("#msg").html("Error while  calling the Web API!");

    };
    $.ajax(options);
   
       
}
