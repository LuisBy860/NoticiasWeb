// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let btn = document.getElementById("ojito");
let pass = document.getElementById("pass");
btn.addEventListener("click", () => {
    if (pass.type == "password") {
        pass.type = "text";
    } else {
        pass.type = "password";
    }
});
