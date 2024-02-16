function recupererJSON(){
     fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    .then( reponse => reponse.json())
    .then(reponse=> {console.log(reponse);
        remplirTableau(reponse);})
    .catch(error=> console.log("Erreur :"+error));
}
recupererJSON();

function remplirTableau(_data) {
    let body = document.querySelector('#tab');

    let mytable = document.createElement("table");
    mytable.setAttribute("id","tab_jeu_de_cartes");

    let myTHead = mytable.createTHead();
    let myFirstRow = myTHead.insertRow();
    let mykeys = [];

    for (const key in _data[0]) {
        let myCell = document.createElement('th');

        myCell.textContent = key;
        mykeys.push(key);
        myFirstRow.appendChild(myCell);

    }

    let myTBody = mytable.createTBody();
    let mySecondRow = myTBody.insertRow();
    for (const key in _data[0]) {


        let myCell = mySecondRow.insertCell();
        myCell.textContent = _data[0][key];
    }

    for (let i = 1; i < _data.length; i++) {
        let myObj = _data[i];
        let myNextRow = myTBody.insertRow();

        for (let j = 0; j < mykeys.length; j++) {

            let myCell = myNextRow.insertCell();
            if (mykeys[j] != "description") {
                myCell.textContent = myObj[mykeys[j]];
            }
            else {
                myCell.textContent = "";
            }
        }
    }
    body.appendChild(mytable);

}

