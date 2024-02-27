
let rouge;
let vert;
let bleu;



function lireCouleur(){
    chaineRouge = document.getElementById("rouge").value;
    chaineVerte = document.getElementById("vert").value;
    chaineBleu = document.getElementById("bleu").value;

    chaineCouleur = "#" + chaineRouge + chaineVerte + chaineBleu;
    /*document.body.style.background = chaineCouleur;*/
    document.body.setAttribute("style", "background-color:" + chaineCouleur);
}

    document.addEventListener("input",function(event){
            switch (event.target.name)
            {
                case "couleur1":
                    if(!event.target.checkValidity())
                    {
                        event.target.value = chaineRouge;   
                        return;
                    }
                break;

                case "couleur2":
                    if(!event.target.checkValidity())
                    {
                        event.target.value = chaineVerte;
                        return;
                    }
                break;

                case "couleur3":
                    if(!event.target.checkValidity())
                    {
                        event.target.value = chaineBleu;
                        return;
                    }
                break;
            }
            lireCouleur();
    });

    monBtnRouge = document.querySelector("#rouge-button");
    monBtnRouge.addEventListener("click",function(){  
        document.getElementById("rouge").value = "FF";
        document.getElementById("vert").value = "00";
        document.getElementById("bleu").value = "00";
        lireCouleur();
    });

    monBtnVert = document.querySelector("#vert-button");
    monBtnVert.addEventListener("click",function(){  
        document.getElementById("rouge").value = "00";
        document.getElementById("vert").value = "FF";
        document.getElementById("bleu").value = "00";
        lireCouleur();
    });

    monBtnBleu = document.querySelector("#bleu-button");
    monBtnBleu.addEventListener("click",function(){  
        document.getElementById("rouge").value = "00";
        document.getElementById("vert").value = "00";
        document.getElementById("bleu").value = "FF";
        lireCouleur();
    });


    
