// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#editButton").click(function () {

    $("#productName").html(`<label asp-for="Name" class="control-label"></label>
                            <input asp-for="Name" class="form-control" />
                            <span asp-validation-for="Name" class="text-danger"></span>`)

    $("#productDescription").html(`<label asp-for="Description" class="control-label"></label>
                                   <input asp-for="Description" class="form-control" />
                                   <span asp-validation-for="Name" class="text-danger"></span>`)

    $("#productPrice").html(`<label asp-for="Price" class="control-label"></label>
                             <input asp-for="Price" class="form-control" />
                             <span asp-validation-for="Price" class="text-danger"></span>`)
})