const dateInput = document.querySelector("input[name=date]");
const hourInput = document.querySelector("input[name=heure]");
const hourOut = document.querySelector("input[name=firstHour]");

const dateBtn = document.querySelector("button[name=dateBtn]");
const hourBtn = document.querySelector("button[name=heureBtn]");

let currentDate = new Date();

function setTheDate(){
    dateInput.value = currentDate.getFullYear()+"-"+((currentDate.getMonth()+1)<10?"0"+(currentDate.getMonth()+1):(currentDate.getMonth()+1))+
    "-"+(currentDate.getDate()<10?"0"+currentDate.getDate():currentDate.getDate());
    dateBtn.setAttribute("disabled",true);
    dateInput.setAttribute("disabled",true);
}

function returnFirstHour(dateEntree){
    let test = new Date()-dateEntree;
    let tempDate = new Date(test);
    let dateSortie = (tempDate.getHours()<10?"0"+(tempDate.getHours()-1):tempDate.getHours()) + ":" 
    + (tempDate.getMinutes()<10?"0"+tempDate.getMinutes():tempDate.getMinutes())+":" + 
    (tempDate.getSeconds()<10?"0"+tempDate.getSeconds():tempDate.getSeconds());
    hourOut.value = dateSortie;
}

function setTheHour(){
    let currentDate = new Date();
    hourInput.value = (currentDate.getHours()<10?"0"+currentDate.getHours():currentDate.getHours()) + ":" 
    + (currentDate.getMinutes()<10?"0"+currentDate.getMinutes():currentDate.getMinutes())+":" + 
    (currentDate.getSeconds()<10?"0"+currentDate.getSeconds():currentDate.getSeconds());
}


dateBtn.addEventListener("click",setTheDate);
hourBtn.addEventListener("click",function(){
    setInterval(setTheHour,1000);
    const firstDate = new Date();
    setInterval(returnFirstHour,1000,firstDate);
    hourBtn.setAttribute("disabled",true);
    hourInput.setAttribute("disabled",true);
    hourOut.setAttribute("disabled",true);
});


document.querySelector("form").addEventListener("submit",function(e){
    e.preventDefault();
})