// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function togglePassword() {
    var passwordField = document.getElementById("passwordField");
    if (passwordField.type === "password") {
        passwordField.type = "text";
    } else {
        passwordField.type = "password";
    }
}

function ocultarButton() {
    var btnOcultar = document.getElementById("btnAula");
    if (btnOcultar.style.display === "block") {
        btnOcultar.style.display = "none";
    }
}

function mensajeAlert(mensaje) {
    return alert(mensaje);
}