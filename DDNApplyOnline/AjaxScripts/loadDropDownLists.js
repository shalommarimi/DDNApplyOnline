function loadLists() {
    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetPopulationList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#population").append("<option  value=" + element.PkPopulationId + ">" + element.PopulationValue + " </option>");

            });
        };
        options.error = function () {
            var ms = $("#msg").html("Server error! Failed to populate Populations");

        };
        $.ajax(options);
    });

    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetGenderList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#gender").append("<option  value=" + element.PkGenderId + ">" + element.GenderValue + " </option>");

            });
        };
        options.error = function () {
            $("#msg").html("Server error! Failed to populate Gender");

        };
        $.ajax(options);
    });




    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetNationalityList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#nationality").append("<option  value=" + element.PkNationalityId + ">" + element.NationalityValue + " </option>");

            });
        };
        options.error = function () {
            $("#msg").html("Server error! Failed to populate Nationalities");

        };
        $.ajax(options);
    });



    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetMaritalStatusList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#marital").append("<option  value=" + element.PkMaritalStatusId + ">" + element.MaritalStatusValue + " </option>");

            });
        };
        options.error = function () {
            $("#msg").html("Server error! Failed to populate Marital Statuses");

        };
        $.ajax(options);
    });




    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetApplicationFieldList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#field").append("<option  value=" + element.PkApplicationFieldId + ">" + element.FieldName + " </option>");

            });
        };
        options.error = function () {
            $("#msg").html("Server error! Failed to populate Application Fields");

        };
        $.ajax(options);
    });




    $(document).ready(function () {
        var options = {};
        options.url = "http://localhost:53017/api/DropDownLists/GetApplicationTypeList";
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            data.forEach(function (element) {
                $("#apptype").append("<option  value=" + element.PkApplicationTypeId + ">" + element.ApplicationTypeName + " </option>");

            });
        };
        options.error = function () {
            $("#msg").html("Server error! Failed to populate Application Types");

        };
        $.ajax(options);
    });

}