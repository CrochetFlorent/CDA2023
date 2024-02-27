
async function recupererJson()
{
    const reponse = await fetch("./json/zipcodes.json")
    const data = await reponse.json();

    return data;
}

function creerOptions(_data){
    const dataList = document.querySelector("#villes");
    _data.forEach(element => {
        const monOption = document.createElement("option");
        monOption.value = element.codePostal; 
        monOption.textContent = element.nomCommune;
        dataList.appendChild(monOption);  
    });
}

const test = await recupererJson();

document.addEventListener("input",function(){
    creerOptions(test);
});



    
    
            



