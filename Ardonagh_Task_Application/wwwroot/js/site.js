function populateForm(i) {
    $.ajax({
        url: 'Home/PopulateForm',
        type: 'GET',
        data: { id: i },
    dataType: 'json',
    success: function (response) {
        $('#id').val(response.id);
        $('#name').val(response.name);
        $('#postcode').val(response.postcode);
        $('#age').val(response.age);
        $('#height').val(response.height);
        $("#form-action").val("Update Customer");
        $("#form-action").attr("action", "/Home/Update");
    }
    });
}