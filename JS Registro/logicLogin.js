
class Usuario{
    constructor(nombre, apellido, usuario, pass){
        this.nombre = nombre;
        this.apellido = apellido;
        this.usuario = usuario;
        this.pass = pass;
    }
}

var formularioLogin = document.getElementById('formLogin');

formularioLogin.addEventListener('submit', evento)
    
function evento(b)
{
    b.preventDefault();
    var datos = new FormData(formularioLogin);

    user = datos.get('user');
    pass = datos.get('pass');
    
    const url = 'https://localhost:7058/api/Login/ObtenerRegistros';
    fetch(url)
        .then(res => res.json())
        .then(datosObtenidos => {
            
            for(let i = 0; i<datosObtenidos.length; i++){
                //console.log(datosObtenidos[i].email);
                //console.log(datosObtenidos[i]);
                

                if(datosObtenidos[i].email == datos.get('user') && datosObtenidos[i].pass == datos.get('pass')){
                    var user = new Usuario(datosObtenidos[i].nombre,datosObtenidos[i].apellido,datosObtenidos[i].email,datosObtenidos[i].pass);
                    jsonUser = JSON.stringify(user);

                    localStorage.setItem('datosUser', jsonUser);
                    window.open('Bienvenida.html','_self');
                }
                
            }
        })
    
}

