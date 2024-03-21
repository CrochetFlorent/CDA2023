async function getJSON()
{
    const response = await fetch("../www/json/listing.json")
    const datas = await response.json();
    return datas;
}

async function createCarousel(_innerDiv)
{
    let dataJSON = await getJSON();


    for (let index = 0; index < dataJSON.datas.length; index++) 
    {
        let maDivItem = document.createElement("div");
        maDivItem.classList.add('carousel-item');
        maDivItem.setAttribute("data-bs-interval","2000");

        if(index == 0)
        {  
            maDivItem.classList.add('active');
        }
       
        let img = document.createElement("img");
        img.classList.add('d-block');
        img.classList.add('w-100');

        let maDivCaption = document.createElement("div");
        maDivCaption.classList.add("carousel-caption","d-none","d-md-block","bg-body","bg-opacity-50","rounded-5");

        img.setAttribute("src","/www/img_slider_modif/fond"+dataJSON.datas[index].id+".jpg");
        img.setAttribute("alt","...");
        maDivItem.appendChild(img);
        
        let myTitle = document.createElement("h5");
        myTitle.innerText = dataJSON.datas[index].titre;
        myTitle.style.textAlign = "center";
        myTitle.style.color = "white";

        let myPara = document.createElement("p");
        myPara.innerText = dataJSON.datas[index].accroche;
        myPara.style.textAlign = "center";
        myPara.style.color = "white";

        maDivCaption.appendChild(myTitle);
        maDivCaption.appendChild(myPara);

        _innerDiv.appendChild(maDivItem);
        maDivItem.appendChild(maDivCaption);
    }

}

function createIndicators(_indicatorsDiv){
    
    for (let index = 1; index <= 10; index++) {
        let myIndicator = document.createElement("button");

        if(index == 1)
        {
            myIndicator.classList.add("active");
            myIndicator.setAttribute("aria-current","true");
        }

        myIndicator.setAttribute("data-bs-target","#carouselExampleDark");
        myIndicator.setAttribute("data-bs-slide-to",""+(index-1)+"");
        myIndicator.setAttribute("aria-label","Slide "+(index));
        myIndicator.classList.add("filter-invert");

        _indicatorsDiv.appendChild(myIndicator);
    }
}

//Main div
let carouselDiv = document.getElementById("carouselExampleDark");
carouselDiv.classList.add('carousel','slide');
carouselDiv.setAttribute("data-bs-ride","carousel");

//Slide buttons div : indicators, and buttons
let indicatorsDiv = document.createElement("div");
indicatorsDiv.classList.add("carousel-indicators");

//Inner Div
let innerDiv = document.createElement("div");
innerDiv.classList.add('carousel-inner');

//Left slide button
let previousButton = document.createElement("button");
previousButton.classList.add('carousel-control-prev');
previousButton.setAttribute("data-bs-target","#carouselExampleDark");
previousButton.setAttribute("data-bs-slide","prev");
previousButton.innerText = "Previous";
previousButton.style.color = "black";
previousButton.style.fontWeight = "bold";

let span1_1 = document.createElement("span");
span1_1.classList.add('carousel-control-prev-icon');
span1_1.setAttribute("aria-hidden","true");

let span1_2 = document.createElement("span");
span1_2.classList.add('visually-hidden');

//right slide button
let nextButton = document.createElement("button");
nextButton.classList.add('carousel-control-next');
nextButton.setAttribute("data-bs-target","#carouselExampleDark");
nextButton.setAttribute("data-bs-slide","next");
nextButton.innerText = "Next";
nextButton.style.color = "black";
nextButton.style.fontWeight = "bold";

let span2_1 = document.createElement("span");
span2_1.classList.add('carousel-control-next-icon');
span2_1.setAttribute("aria-hidden","true");

let span2_2 = document.createElement("span");
span2_2.classList.add('visually-hidden');

previousButton.appendChild(span1_1);
previousButton.appendChild(span1_2);
innerDiv.appendChild(previousButton);

nextButton.appendChild(span2_1);
nextButton.appendChild(span2_2);
innerDiv.appendChild(nextButton);

carouselDiv.appendChild(indicatorsDiv);
carouselDiv.appendChild(innerDiv);

createCarousel(innerDiv);
createIndicators(indicatorsDiv);


