

/**@param {string} chaine */
let form = document.querySelector('form');
let troisieme = document.getElementById("troisieme");

let tabMois =["Janvier","Fevrier","Mars","Avril","Mai","Juin","Juillet","Aout","Septembre","Octobre","Novembre","Decembre"]

const monOptionJour = document.createElement("option");
monOptionJour.setAttribute("hidden","");
monOptionJour.textContent = "Jour";
document.querySelector("#select_jour").appendChild(monOptionJour);


const monOptionMois = document.createElement("option");
monOptionMois.setAttribute("hidden","");
monOptionMois.textContent = "Mois";
document.querySelector("#select_mois").appendChild(monOptionMois);


const monOptionAnnee = document.createElement("option");
monOptionAnnee.setAttribute("hidden","");
monOptionAnnee.textContent = "Annee";
document.querySelector("#select_annee").appendChild(monOptionAnnee);



for(let i=1;i<=31;i++)
{
    // eval(`var input${i} = document.createElement("select");`)
    // eval(`input${i}`).appendChild(troisieme);
    let monOption = document.createElement("option");
    monOption.value = i;
    monOption.textContent = i;
    document.querySelector("#select_jour").appendChild(monOption);
}

for(let i=0;i<12;i++)
{
    // eval(`var input${i} = document.createElement("select");`)
    // eval(`input${i}`).appendChild(troisieme);

    let monOption = document.createElement("option");
    monOption.value = i;
    monOption.textContent = tabMois[i];
    document.querySelector("#select_mois").appendChild(monOption);
}

for(let i=1900;i<=2050;i++)
{
    // eval(`var input${i} = document.createElement("select");`)
    // eval(`input${i}`).appendChild(troisieme);
    let monOption = document.createElement("option");
    monOption.value = i;
    monOption.textContent = i;
    document.querySelector("#select_annee").appendChild(monOption);
}

let jour = document.querySelector('select[name="jour"]');
let mois = document.querySelector('select[name="mois"]');
let annee = document.querySelector('select[name="annee"]');
let prenom = document.querySelector('input[name="prenom"]');
let nom = document.querySelector('input[name="nom"]');
let pseudo = document.querySelector('input[name="pseudo"]');
let email = document.querySelector('input[name="email"]');


function sommeChaine(chaine)
{
    let somme= 0;
    chaine = chaine.toUpperCase();

    for(let i=0;i<chaine.length;i++)
    {
        somme = somme + chaine.charCodeAt(i) -64;
    }
    return somme;
}

let tabSignes = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];

function signeAstro(){
    let month = mois.value;
    if(month == 11 && jour.value>21)
    {
        month = 0;
    }
    else if(jour.value>21)
    {
        month = mois.value+1;
    }
    return tabSignes[month];
}

function formok(){
    let isOk = true;
    for(let i=0;i < form.elements.length;i++)
    {
        if(form.elements[i].value == "" && !form.elements[i].getAttribute('readonly'))
        {
            isOk = false;
            break;
        }
    }
    return isOk;
}


function calculerPseudo(){
    pseudo.value= signeAstro()+sommeChaine(prenom.value)+sommeChaine(nom.value);
}


function Valider(){
    setCookie("Nom",nom.value);
    setCookie("Prenom",prenom.value);
    setCookie("Pseudo",pseudo.value);
    setCookie("Email",email.value);
    setCookie("Date de naissance",jour.value+"-"+mois.value+"-"+annee.value);
    // document.cookie ="Texte="+bigtext.value+"; Expires="+
    // document.cookie ='Nom='+nom.value;
    // document.cookie='Prenom='+prenom.value;
    // document.cookie='Email='+email.value;
    // document.cookie='Date de naissance='+jour.value+"/"+mois.value+"/"+annee.value;
}

function setCookie(_nom,_valeur){
    let time = new Date();
    let timeCookie = new Date(time.getFullYear(),time.getMonth(),time.getDate(),(time.getHours()+1),time.getMinutes(),(time.getSeconds()+120));
    timeCookie = timeCookie.toUTCString();    
    document.cookie = _nom+"="+_valeur+"; Expires="+timeCookie+"; SameSite=Strict; Secure";
}

function getCookie(name){
      let monTabCookie = document.cookie.split('; ');
      let maValeur={};
      let i=0;
    for (let index = 0; index < monTabCookie.length; index++) 
    {
         maValeur[index]= monTabCookie[index].split(`=`);
        
    }
    return maValeur[name];
}

function getCookie2(name) {
    let cookie = {};
    document.cookie.split(';').forEach(function(el) {
      let split = el.split('=');
      cookie[split[0].trim()] = split.slice(1).join("=");
    })
    return cookie[name];
  }

let btnValider = document.querySelector("submit");

function nbJoursAnniv(anniv){
    let maDate = new Date(time.getFullYear(),time.getMonth(),time.getDate());
}


document.addEventListener("focusout",function(){
    calculerPseudo();
});
document.addEventListener("submit",function(){
    calculerPseudo();
    Valider();
    open("./Accueil.html");
});
