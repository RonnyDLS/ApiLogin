var formulario = document.getElementById('form_regi');

formulario.addEventListener('submit', function(a){
    a.preventDefault();

    var datos = new FormData(formulario);

    nombre = datos.get('nombre_regi');
    apellido = datos.get('apellido_regi');
    email = datos.get('email_regi');
    pass = datos.get('password_regi');
    direc = datos.get('direccion_regi');

    const obj = {
        "id": 0,
        "nombre": `${nombre}`,
        "apellido": `${apellido}`,
        "email": `${email}`,
        "pass": `${pass}`,
        "direccion": `${direc}`,
        "contactos": []
      }
      const Userjson = JSON.stringify(obj)

    const url = 'https://localhost:7058/api/Login/Registrar';
    fetch(url, {
        method: 'POST',
        body: Userjson,
        headers: {
            'Content-Type':'application/json'
        }
    })
    .then(res => res.text())
    .then(mensage => {
        alert(mensage)
        //location.reload();
        window.location.href = "Login.html"
    })
})
