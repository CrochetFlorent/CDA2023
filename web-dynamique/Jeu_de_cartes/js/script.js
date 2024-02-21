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

       for (let i = 0; i < _data.length; i++) {
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
    creerImage(bestArmor);
    creerImage(mostPlayed);
    creerImage(mostVictories);
}

function sortByValue(_data,param){
    let tri = _data.sort((a,b)=> a[param]<b[param] ? 1 : -1);
    return tri[0];
}

function creerImage(_best){

    let div_Principale = document.createElement("div");
    div_Principale.className = "div_principale";


    let div_nom_played = document.createElement("div");
    div_nom_played.className= "div_nom_played";
    let div_nom = document.createElement("div");
    div_nom.className = "div_nom";
    let div_played = document.createElement("div");
    div_played.className = "div_played";
    let div_num = document.createElement("div");
    div_num.className = "div_num";
    let div_img = document.createElement("div");
    div_img.className = "div_img";

    let div_stats = document.createElement("div");
    div_stats.className = "div_stats";

    let div_stat1 = document.createElement("div");
    div_stat1.className= "div_stat1";
    let div_stat1_value = document.createElement("div");
    div_stat1.className= "div_stat1_value";

    let div_stat2 = document.createElement("div");
    div_stat2.className= "div_stat2";
    let div_stat2_value = document.createElement("div");
    div_stat2.className= "div_stat2_value";

    let div_stat3 = document.createElement("div");
    div_stat3.className= "div_stat3";
    let div_stat3_value = document.createElement("div");
    div_stat3.className= "div_stat3_value";

    let armor = document.createElement("img");

    armor.setAttribute("src","img/armure.png");
    armor.setAttribute("class","armor");

    div_num.innerText = _best.id;
    div_nom.innerText = _best.name;
    div_played.innerText = "Played:" + _best.played + "  |  Victories: " + _best.victory;

    div_stat1.innerText = "Power";
    div_stat1_value.innerText =_best.power;
    div_stat1_value.style.color = 'violet';
    div_stat2.innerText = "Attack";
    div_stat2_value.innerText = _best.attack;
    div_stat2_value.style.color = 'red';
    div_stat3.innerText = "Defense";
    div_stat3_value.innerText =_best.armor;
    div_stat3_value.style.color = 'blue';

    div_img.appendChild(armor);

    div_Principale.appendChild(div_num);

    div_nom_played.appendChild(div_nom);
    div_nom_played.appendChild(div_played);
    div_Principale.appendChild(div_nom_played);
    
    div_Principale.appendChild(div_img);

    div_Principale.appendChild(div_stats);
    div_stats.appendChild(div_stat1);
    div_stats.appendChild(div_stat2);
    div_stats.appendChild(div_stat3);

    div_stat1.appendChild(div_stat1_value);
    div_stat2.appendChild(div_stat2_value);
    div_stat3.appendChild(div_stat3_value);

    main.appendChild(div_Principale);
}

remplirTableau();

