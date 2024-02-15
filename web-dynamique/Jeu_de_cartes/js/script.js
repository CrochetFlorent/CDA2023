function recupererJSON(){
     fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    .then( reponse => reponse.json())
    .then(reponse=> {console.log(reponse);
        remplirTableau(reponse);})
    .catch(error=> console.log("Erreur :"+error));
}
recupererJSON();



function remplirTableau(_data){
    let body = document.querySelector('#tab');

    let mytable=document.createElement("table");

    let myTHead = mytable.createTHead();
    let myFirstRow = myTHead.insertRow();


    
    
        for (const key in _data[0]) {
            let myCell  = document.createElement('th');
            myCell.textContent = key;
            myFirstRow.appendChild(myCell);
        }    
    

    body.appendChild(mytable);

}

