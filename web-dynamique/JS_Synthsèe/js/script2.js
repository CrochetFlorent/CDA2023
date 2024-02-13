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
    let tabNaissance = getCookie("Date de naissance").split("-");
    let dateNaissance = new Date(tabNaissance[2],(tabNaissance[1]-1),tabNaissance[0]);
console.log(dateNaissance);
    let joursAvantAnniv ;
     let dateAnniv =new Date(dateJour.getFullYear(),dateNaissance.getMonth(),dateNaissance.getDate());
      if(dateJour > dateAnniv)
      {

          dateAnniv = new Date((dateJour.getFullYear()+1),dateNaissance.getMonth(),dateNaissance.getDate());
      }
     
      
      dateAnniv = dateAnniv.getTime();
      
    console.log(dateAnniv);
    joursAvantAnniv = (dateAnniv-dateJour)/(1000*3600*24);
    
    return  Math.ceil(joursAvantAnniv,0);
  }


  function ecrireAccueil()
  {
    document.getElementById("nom").innerText = getCookie("Nom");
    document.getElementById("prenom").innerText = getCookie("Prenom");
    document.getElementById("pseudo").innerText = getCookie("Pseudo");
    document.getElementById("email").innerText = getCookie("Email");
    document.getElementById("date_de_naissance").innerText = getCookie("Date de naissance");
    let montab =getCookie("Date de naissance").split('-');
    console.log(montab[0]) ;
    document.getElementById("jours_avant_anniv").innerText= nbJoursAnniv();
    
  }


document.addEventListener("DOMContentLoaded",function(){
  ecrireAccueil();
  
})
  //intervalle entre (naissance et aujourd'hui) = intervalle entre (origine et aujourd'hui) - intervalle entre (origine et naissance)