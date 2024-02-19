async function recupererJSON(){
     let reponse = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
     let data = await reponse.json();
     return data;
}

var body = document.querySelector("body");
var main = document.querySelector("main");
var mytable = document.createElement("table");
body.appendChild(main);
main.appendChild(mytable);

async function remplirTableau() {
    var _data = await recupererJSON();

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
        let myNextRow = myTBody.insertRow();

        for (let j = 0; j < mykeys.length; j++) {
            let myCell = myNextRow.insertCell();
            myCell.textContent = _data[i][mykeys[j]];        
        }
    }

    let bestAttack = sortByValue(_data,"attack");
    let bestArmor = sortByValue(_data,"armor");
    let mostPlayed = sortByValue(_data,"played");
    let mostVictories = sortByValue(_data,"victory");

    creerImage(bestAttack);
}

function sortByValue(_data,param){
    let tri = _data.sort((a,b)=> a[param]<b[param] ? 1 : -1);
    return tri[0];
}

function creerImage(_best){
    let div_Principale =document.createElement("div");
    div_Principale.id = "div_principale";
    let div_in_1 = document.createElement("div");
    div_in_1.id = "div_in_1";
    let div_in_2 = "div_in_2";

    div_in_1.innerText = _best.attack;
    div_in_2.innerText = "salut";
    div_Principale.appendChild(div_in_1);
    div_Principale.appendChild(div_in_2);
    main.appendChild(div_Principale);
}

remplirTableau();

