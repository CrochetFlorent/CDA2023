

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

let bigtext = document.querySelector('textarea[name="bigtext"]');
let jour = document.querySelector('select[name="jour"]');
let mois = document.querySelector('select[name="mois"]');
let annee = document.querySelector('select[name="email"]');
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
    return tabSignes[mois.value];
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


function renseignerCookies(){
    document.cookie ="Texte: "+bigtext.value+" Nom: "+nom.value+" Prenom: "+prenom.value+" Email: "+email.value;
}

document.addEventListener("focusout",renseignerCookies);