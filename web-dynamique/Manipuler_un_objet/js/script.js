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
    let tabTd=[];
    for (var i=0;i<5;i++) 
    {
        if(i!=3)
        {
            var myTd = myRow.insertCell();
            i === 4 ? myTd.textContent = myEmployee[obj[i-1]] : myTd.textContent = myEmployee[obj[i]];
            tabTd[i]=myTd.textContent;
        }else
        {
            var myTdEmail = myRow.insertCell();
            myTdEmail.textContent = creerEmailObject();
            tabTd[i]=myTdEmail.textContent;
        }
    }
    return tabTd;
}

function creerEmailObject(){
  return myEmployee["firstname"].toLowerCase()+"."+myEmployee["lastname"].toLowerCase()+"@"+"example.com";
}

function creerEmailInput(){
    return input_prenom.value.toLowerCase()+"."+input_nom.value.toLowerCase()+"@"+"example.com";
  }

function modifierUtilisateur(_tabTd,myEmployee){
    let inputTab = [input_prenom,input_nom,input_naissance,input_salaire];
    for (var i=0;i<5;i++) 
    {
        if(i!=3)
        {       
            i == 4 ? console.log(inputTab[i-1].value) : console.log(inputTab[i].value);
        }else
        {
            console.log(creerEmailInput());
        }
    }
}

document.addEventListener("DOMContentLoaded",function(){
    let _tabTd = remplirDonnees();

    onClick.addEventListener("click",function(){
        modifierUtilisateur(_tabTd,myEmployee);
    });
});

