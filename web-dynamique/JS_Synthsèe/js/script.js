

/**@param {string} chaine */
let form = document.querySelector('form');
let troisieme = document.getElementById("troisieme");

const monOptionJour = document.createElement("option");
monOptionJour.setAttribute("hidden","");
monOptionJour.setAttribute("value","");
monOptionJour.textContent = "Jour";
document.querySelector("#select_jour").appendChild(monOptionJour);


const monOptionMois = document.createElement("option");
monOptionMois.setAttribute("hidden","");
monOptionMois.setAttribute("value","");
monOptionMois.textContent = "Mois";
document.querySelector("#select_mois").appendChild(monOptionMois);


const monOptionAnnee = document.createElement("option");
monOptionAnnee.setAttribute("hidden","");
monOptionAnnee.setAttribute("value","");
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

let tabMois =["Janvier","Fevrier","Mars","Avril","Mai","Juin","Juillet","Aout","Septembre","Octobre","Novembre","Decembre"]

for(let i=0;i<12;i++)
{
    // eval(`var input${i} = document.createElement("select");`)
    // eval(`input${i}`).appendChild(troisieme);

    let monOption = document.createElement("option");
    monOption.value = i;
    monOption.textContent = tabMois[i];
    document.querySelector("#select_mois").appendChild(monOption);
}

for(let i=1970;i<=2050;i++)
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
let inputValider = document.querySelector('#valider');


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
    inputValider.removeAttribute("Disabled");
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
    let timeCookie = new Date(time.getFullYear(),time.getMonth(),time.getDate(),(time.getHours()+1),time.getMinutes(),(time.getSeconds()+240));
    timeCookie = timeCookie.toUTCString();    
    document.cookie = _nom+"="+_valeur+"; Expires="+timeCookie+"; SameSite=Strict; Secure";
}

document.addEventListener("input",function(){
    if(nom.value!="" && prenom.value!="" && email.value!="" && jour.value!="" && mois.value!="" && annee.value!="")
    {
        calculerPseudo();
        Valider(); 
    }
});

document.addEventListener("submit",function(){
    Valider();
    open("./Accueil.html");
});
