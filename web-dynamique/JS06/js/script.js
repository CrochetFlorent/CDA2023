
function setTwoNumberDecimal(number) {
    number = parseFloat(number).toFixed(2);
    return number;

}
function setValuesOnLoad()
{
    document.querySelector('input[name="quantite1"]').value = 1;
    document.querySelector('input[name="quantite2"]').value = 1;
    document.querySelector('input[name="prix-unitaire1"]').value = 0;
    document.querySelector('input[name="prix-unitaire2"]').value = 0;
    document.querySelector('input[name="prix1"]').value = 0;
    document.querySelector('input[name="prix2"]').value = 0;
    document.querySelector('input[name="resultat"]').value = 0;
}

function setValuesFocusOut()
{
    document.querySelector(('input[name="prix1"]')).value = 
    document.querySelector('input[name="quantite1"]').value * document.querySelector('input[name="prix-unitaire1"]').value;
    document.querySelector(('input[name="prix1"]')).value = setTwoNumberDecimal(document.querySelector(('input[name="prix1"]')).value);

    document.querySelector(('input[name="prix2"]')).value = 
    document.querySelector('input[name="quantite2"]').value * document.querySelector('input[name="prix-unitaire2"]').value;
    document.querySelector(('input[name="prix2"]')).value = setTwoNumberDecimal(document.querySelector(('input[name="prix2"]')).value);

    document.querySelector('input[name="resultat"]').value = 
    setTwoNumberDecimal(Number(document.querySelector(('input[name="prix1"]')).value) + Number(document.querySelector(('input[name="prix2"]')).value));
}



document.addEventListener("DOMContentLoaded",setValuesOnLoad);
document.addEventListener("input",setValuesFocusOut);
