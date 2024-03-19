async function getJSON()
{
    const response = await fetch("../json/listing.json")
    const datas = await response.json();
    return datas;
}

async function createCaroussel(_innerDiv)
{
    let dataJSON = await getJSON();
    console.log(dataJSON);

    for (let index = 0; index < dataJSON.datas.length; index++) 
    {

        console.log(dataJSON.datas[index]);

        let madiv = document.createElement("div");
        madiv.classList.add('carousel-item');
        madiv.setAttribute("data-bs-interval","2000");
        if(index == 0)
        {  
            madiv.classList.add('active');
                    
        }
       

        let img = document.createElement("img");
        img.classList.add('d-block');
        img.classList.add('w-100');
        img.setAttribute("src","/img_slider_modif/fond"+dataJSON.datas[index+1].id+".jpg");
        img.setAttribute("alt","...");
        madiv.appendChild(img);
        
        _innerDiv.appendChild(madiv);
    }
}

//Main div
let carouselDiv = document.getElementById("carouselExampleAutoplaying");
carouselDiv.classList.add('carousel');
carouselDiv.classList.add('slide');
carouselDiv.setAttribute("data-bs-ride","carousel");


//Inner Div
let innerDiv = document.createElement("div");
innerDiv.classList.add('carousel-inner');

//Left slide button
let previousButton = document.createElement("button");
previousButton.classList.add('carousel-control-prev');
previousButton.setAttribute("data-bs-traget","#carouselExampleAutoplaying");
previousButton.innerText = "Previous";

let span1_1 = document.createElement("span");
span1_1.classList.add('carousel-control-prev-icon');

let span1_2 = document.createElement("span");
span1_2.classList.add('visually-hidden');

//right slide button
let nextButton = document.createElement("button");
nextButton.classList.add('carousel-control-next');
nextButton.setAttribute("data-bs-traget","#carouselExampleAutoplaying");
nextButton.innerText = "Next";

let span2_1 = document.createElement("span");
span2_1.classList.add('carousel-control-prev-icon');
span2_1.setAttribute("aria-hidden","true");

let span2_2 = document.createElement("span");
span2_2.classList.add('visually-hidden');

previousButton.appendChild(span1_1);
previousButton.appendChild(span1_2);
innerDiv.appendChild(previousButton);

nextButton.appendChild(span2_1);
nextButton.appendChild(span2_2);
innerDiv.appendChild(nextButton);

carouselDiv.appendChild(innerDiv);

createCaroussel(innerDiv);


