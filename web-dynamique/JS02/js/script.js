const dateInput = document.querySelector("input[name=date]");
const hourInput = document.querySelector("input[name=heure]");
const hourOut = document.querySelector("input[name=firstHour]");

const dateBtn = document.querySelector("button[name=dateBtn]");
const hourBtn = document.querySelector("button[name=heureBtn]");

let currentDate = new Date();

function setTheDate(){
    dateInput.value = currentDate.toLocaleDateString('en-CA');
    dateBtn.setAttribute("disabled",true);
    dateInput.setAttribute("disabled",true);
}

function returnInterval(dateEntree){
    let currentDate = new Date();
    let year = currentDate.getFullYear();
    let month = currentDate.getMonth();
    let day = currentDate.getDay();
    let hour = currentDate.getHours();
    let minute = currentDate.getMinutes();
    let seconde = currentDate.getSeconds();

    let test = new Date(year,month,day,hour-1,minute,seconde)-dateEntree;
    let tempDate = new Date(test);
    let timeOut = tempDate.toLocaleTimeString();
    hourOut.value = timeOut;
}

function setTheHour(){
    let currentDate = new Date();
    hourInput.value = currentDate.toLocaleTimeString();
}


dateBtn.addEventListener("click",setTheDate);
hourBtn.addEventListener("click",function(){
    setInterval(setTheHour,1000);
    setInterval(returnInterval,1000,currentDate);
    hourBtn.setAttribute("disabled",true);
    hourInput.setAttribute("disabled",true);
    hourOut.setAttribute("disabled",true);
});


document.querySelector("form").addEventListener("submit",function(e){
    e.preventDefault();
})