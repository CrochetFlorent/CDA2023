function getCookie(name){
  let monTabCookie = document.cookie.split('; ');
  let monTabValeurs=[];
  let maValeur;
for (let index = 0; index < monTabCookie.length; index++) 
{
     monTabValeurs= monTabCookie[index].split(`=`);
     if(monTabValeurs[0] == name)
     {
         console.log(monTabValeurs[1]);
         maValeur = monTabValeurs[1];     
         break;
     }        
}
  return maValeur.trim();
}

  function nbJoursAnniv(){
    
    let dateJour=new Date();
    console.log("datejour:" +dateJour);

    let tabDateDeNaissance = getCookie("Date de naissance").split();
    interval = Date.parse(tabDateDeNaissance[2]+"-"+tabDateDeNaissance[1]+"-"+tabDateDeNaissance[0]);


    let temp;
    let annees;

    temp = dateJour.getTime() - interval; 
       
    temp = temp/(1000*3600*24);

    return  temp.toFixed(2);
  }

  function ecrireAccueil()
  {
    document.getElementById("nom").innerText = getCookie("Nom");
    document.getElementById("prenom").innerText = getCookie("Prenom");
    document.getElementById("pseudo").innerText = getCookie("Pseudo");
    document.getElementById("email").innerText = getCookie("Email");
    document.getElementById("date_de_naissance").innerText = getCookie("Date de naissance");
    document.querySelector("#jours_avant_anniv").innerText= nbJoursAnniv();
    
  }

ecrireAccueil();
addEventListener("focusout",nbJoursAnniv);
  //intervalle entre (naissance et aujourd'hui) = intervalle entre (origine et aujourd'hui) - intervalle entre (origine et naissance)