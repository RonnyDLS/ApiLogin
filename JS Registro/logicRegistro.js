

class Registro{
    constructor(nombre, apellido, email,pass){
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.pass = pass;
    }
}

var formulario = document.getElementById('form_regi');

formulario.addEventListener('submit', function(a){
    a.preventDefault();

    var datos = new FormData(formulario);

    nombre = datos.get('nombre_regi');
    apellido = datos.get('apellido_regi');
    email = datos.get('email_regi');
    pass = datos.get('password_regi');

    var p1 = new Registro(nombre,apellido,email,pass);
    
    const jsonP1 = JSON.stringify(p1);

    const url = 'https://localhost:7058/api/Login/Registrar';
    fetch(url, {
        method: 'POST',
        body: jsonP1,
        headers: {
            'content-type':'application/json'
        }
    })
    .then(res => res.text())
    .then(mensage => {
        alert(mensage)
        location.reload();
    })
})
