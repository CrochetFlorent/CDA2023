
async function recupererJson()
{
    const reponse = await fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
    const data = await reponse.json();

    return data;
}

for(let i=0;i<_data.length;i++)
{
    let datalistVilles = document.querySelector("#villes");
    // eval(`var input${i} = document.createElement("select");`)
    // eval(`input${i}`).appendChild(troisieme);
    let monOption = document.createElement("option");
    monOption.value = _data[i].
    monOption.textContent = i;
    document.querySelector("#select_jour").appendChild(monOption);
}

function creerSuggestions(_data){
    let input = document.querySelector("#code_postal");

    for(let i=0;i<_data.length;i++)
    {
            if(_data[i].codePostal.includes(input.value))
            {
                
            }
    }
}

document.addEventListener("focusout",async function(){
    const test = await recupererJson();
    creerSuggestions(test);
});


    
    
            



