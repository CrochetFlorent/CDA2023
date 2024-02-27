const myEmployee = {
    lastname: "Doe", 
    firstname: "John", 
    birthday: "1981-11-12", 
    salary: 2150
}

let monTableau = document.querySelector("table");
let myTBody = monTableau.createTBody();
let myRow = myTBody.insertRow();

let input_prenom = document.querySelector("#input_prenom");
let input_nom = document.querySelector("#input_nom");
let input_naissance = document.querySelector("#input_naissance");
let input_salaire = document.querySelector("#input_salaire");

let onClick = document.querySelector("#onClick");

function remplirDonnees(){
    let obj =Object.keys(myEmployee);
    var index = 0;
    for (var i=0;i<5;i++) 
    {
        if(i!=3)
        {
            var myTd = myRow.insertCell();
            i === 4 ? myTd.textContent = myEmployee[obj[i-1]] : myTd.textContent = myEmployee[obj[i]];
        }else
        {
            var myTdEmail = myRow.insertCell();
            myTdEmail.textContent = creerEmailObject();
        }
    }
}


function creerEmailObject(){
  return myEmployee["firstname"].toLowerCase()+"."+myEmployee["lastname"].toLowerCase()+"@"+"example.com";
}


function modifierUtilisateur(_tabTd){
    let inputTab = [input_prenom,input_nom,input_naissance,input_salaire];
    let obj = Object.keys(myEmployee);
    console.log(inputTab[input_prenom]);
    obj.lastname = inputTab[0].textContent;
    obj.firstname = inputTab[1].textContent;
    obj.birthday = inputTab[2].textContent;
    obj.salary = inputTab[3].textContent;
    console.log(myEmployee);
}

document.addEventListener("DOMContentLoaded",function(){
    remplirDonnees();
    onClick.addEventListener("click",function(){
        modifierUtilisateur();
        remplirDonnees();
    });
});

