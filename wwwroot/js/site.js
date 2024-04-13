// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.querySelector('#createForm').addEventListener('submit', function(e) {
    e.preventDefault();

    var xhr = new XMLHttpRequest();
    xhr.open(this.method, this.action, true);
    xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    xhr.onload = function() {
        if (xhr.status >= 200 && xhr.status < 400) {
            document.getElementById('successModal').style.display = 'block';
        }
    };
    xhr.send(new URLSearchParams(new FormData(this)).toString());
});


document.getElementById('closeModal').addEventListener('click', function() {
    document.getElementById('successModal').style.display = 'none';
    window.location.href = '/Home/Index'; // Asegúrate de que esta ruta sea correcta
});