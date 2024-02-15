
function recupererJson()
{
    const fetchPromise = fetch(
    "https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
    .then((reponse)=>{
            if(reponse.status==200){
                const jsonpromise = reponse.json().then((json) => {
                    console.log(json);
                
                document.querySelector("#code_postal").addEventListener("input",function(){creerSuggestions(json)});    
                })}})
    .catch(function(reject){console.log("Error")})};

    

function creerSuggestions(_villes){
    let inputValue = document.querySelector("#code_postal").value;

    for(let i=0; i < _villes.length;i++)
    {
        
        
            if ( _villes[i]["codePostal"].includes(inputValue) ) {
                
                for (let key in _villes[i]) {

                    console.log( _villes[i].key);
                }
                
            }
        


       
    }
}




    
    
            



