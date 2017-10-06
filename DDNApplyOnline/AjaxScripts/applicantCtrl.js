function ApplyNow() {
    $("#btnApplyNow").click(function () {
        var options = {};
        options.url = "http://localhost:53017/api/Applicant/Apply";
        options.type = "POST";

        var obj = {};
        obj.FirstName = $("#names").val();
        obj.LastName = $("#lastname").val();
        obj.EmailAddress = $("#email").val();
        obj.FkGenderId = $("#gender").val();
        obj.DOB = $("#dob").val();
        obj.IdNumber = $("#idnumber").val();
        obj.FkNationalityId = $("#nationality").val();
        obj.FkPopulationId = $("#population").val();
        obj.CellNumber = $("#cellnumber").val();
        obj.DriversLicence = $("#licence").val();
        obj.FkMaritalStatusId = $("#marital").val();
        obj.HomeLanguage = $("#homelanguage").val();
        obj.Prefered = $("#pre").val();
        obj.FirstOtherLanguage = $("#langauge1").val();
        obj.SecondOtherLanguage = $("#langauge2").val();
        obj.ThirdOtherLanguage = $("#langauge3").val();
        obj.FkApplicationTypeId = $("#apptype").val();
        obj.FkApplicationFieldId = $("#field").val();
        obj.Username = $("#username").val();
        obj.New_Password = $("#pass").val();
        obj.ConfirmPassword = $("#cpass").val();

        options.data = JSON.stringify(obj);
        options.contentType = "application/json";
        options.dataType = "html";
        crossDomain: true;
        options.success = function (msg) {
            $("#msg").html(msg);
        };



    });
}