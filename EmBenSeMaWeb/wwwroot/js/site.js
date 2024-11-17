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
}

function mostrarNotificacion(elemento) {
    var contenido = document.getElementById("mensajeContenido");
    if (contenido.style.display == "none") {
        contenido.style.display = "block";
    }
    

    // Obtener los valores desde los atributos data-*
    const asunto = elemento.getAttribute('data-asunto');
    const fecha = elemento.getAttribute('data-fecha');
    const cuerpo = elemento.getAttribute('data-cuerpo');

    // Actualizar el contenido de los elementos de detalle
    document.getElementById('detalleAsunto').innerHTML = `<strong>Asunto:</strong> ${asunto}`;
    document.getElementById('detalleFecha').innerHTML = `<strong>Fecha:</strong> ${fecha}`;
    document.getElementById('detalleCuerpo').innerHTML = `<strong>Mensaje:</strong> ${cuerpo}`;
}
