
function recupererJson()
{
    const fetchPromise = fetch(
    "https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
    .then((reponse)=>{
            if(reponse.status==200){
                const jsonpromise = reponse.json().then((json) => {
                    console.log(json);
                creerSuggestions(json);
                document.querySelector("#code_postal").addEventListener("input",function(){creerSuggestions});    
                })}})
    .catch(function(reject){console.log("Error")})};

    

function creerSuggestions(villes){
    let inputCode = document.querySelector("#code_postal");

    for(let i=0; i < villes.length;i++)
    {
        if(villes[i].codePostal == inputCode.textContent)
        {
                let option = document.createElement("option");
                option.textContent =villes[i];
                document.querySelector("#villes").appendChild(option);
        }
    }
}

document.addEventListener("DOMContentLoaded",recupererJson);


    
    
            



