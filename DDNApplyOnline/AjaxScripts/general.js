function unhidePassword() {
    $(document).ready(function () {

        $("#pass").focus();

        $("#pwcheck").click(function () {
            if ($("#pwcheck").is(":checked")) {
                $("#pass, #cpass").clone()
                .attr("type", "text").insertAfter("#pass, #cpass")
                .prev().remove();
            }
            else {
                $("#pass, #cpass").clone()
                .attr("type", "password").insertAfter("#pass, #cpass")
                .prev().remove();
            }
        });
    });
}