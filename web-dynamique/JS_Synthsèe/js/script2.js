function getCookie(name) {
    let cookie = {};
    document.cookie.split(';').forEach(function(el) {
      let split = el.split('=');
      cookie[split[0].trim()] = split.slice(1).join("=");
    })
    return cookie[name];
  }



  function ecrireAccueil(){
    document.getElementById("nom").innerText = getCookie("Nom");
    document.getElementById("prenom").innerText = getCookie("Prenom");
    document.getElementById("pseudo").innerText = getCookie("Pseudo");
    document.getElementById("email").innerText = getCookie("Email");
    document.getElementById("date_de_naissance").innerText = getCookie("Date de naissance");
  }

  console.log(document.getElementById("prenom"));
  ecrireAccueil();