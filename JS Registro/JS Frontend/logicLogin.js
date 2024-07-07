
class Usuario{
    constructor(email, pass){
        this.email = email;
        this.pass = pass;
    }
}

var formularioLogin = document.getElementById('formLogin');

formularioLogin.addEventListener('submit', evento)
    
function evento(b)
{
    b.preventDefault();
    var datos = new FormData(formularioLogin);
    
    const user = new Usuario(datos.get('user'),datos.get('pass'))
    const userJson = JSON.stringify(user)

    const url = 'https://localhost:7058/api/Login/Validar';
    fetch(url,{
        method : "POST",
        body : userJson,
        headers : {
            "Content-Type" : "application/json"
        }
        
    })
        .then(res => res.json())
        .then(datosObtenidos => {
            if(datosObtenidos.confimacion === true){
                localStorage.setItem("data", JSON.stringify(datosObtenidos))
                location.href = "Bienvenida.html";
            }else{
                alert("Credenciales incorrectas")
            }
        })
}

