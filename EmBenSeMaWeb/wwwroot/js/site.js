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

// Función para actualizar el nombre de usuario en el botón
function userSesion(username) {
    var name = document.getElementById("user-name");

    if (name) {
        name.textContent = username;
    }
}

function toggleMenu() {
    var menu = document.getElementById("user-menu");
    menu.style.display = menu.style.display === "block" ? "none" : "block";
}

window.onclick = function (event) {
    var menu = document.getElementById("user-menu");
    var button = document.querySelector(".user-button");
    if (event.target !== button && !button.contains(event.target) && menu.style.display === "block") {
        menu.style.display = "none";
    }
};


function mensajeAlert(mensaje) {
    return alert(mensaje);
}