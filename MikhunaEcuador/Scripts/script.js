const cardLogin = document.getElementById('cardLoginID');
const gF = document.getElementById('gF');
const gT = document.getElementById('gT');

const gI = document.getElementById('gI');

const displayGf = gF.getAttribute("display");
const displayGt = gT.getAttribute("display");

function girarLogin() {
    //cardLogin class
    gF.style.visibility = "hidden";
    gF.style.display = "none";

    gT.style.visibility = "visible";
    gT.style.display = displayGt;

    cardLogin.style.transform = "rotateY(180deg)";
    gT.style.transform = "rotateY(-180deg)";

    cardLogin.style.transition = "all 400ms ease-in-out";
    cardLogin.style.perspective = "1000px";
    //document.getElementsByClass('giroTrasero-login');
}

girarLogin();

function girarLogin2() {
    //cardLogin class
    gT.style.display = "none";
    gT.style.visibility = "hidden";
    gF.style.display = displayGf;
    gF.style.visibility = "visible";
    
    

    cardLogin.style.transform = "rotateY(-180deg)";
    gF.style.transform = "rotateY(180deg)";

    cardLogin.style.transition = "all 400ms ease-in-out";
    cardLogin.style.perspective = "1000px";
    //document.getElementsByClass('giroTrasero-login');

}

var btnCrearReceta = Document.getElementById("btnCrearReceta");


function mostrar() {
    var receta = Document.getElementById("mostrarReceta");
    var ingrePasos = Document.getElementById("oculto1");
    receta.style.visibility = "hidden";
    ingrePasos.style.visibility = "initial";
}





