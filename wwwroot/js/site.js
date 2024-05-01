const validateText = (event) => {

    document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Minst 4 tecken"
    
}



//MODAL POPUP --------------------------------------------------------
// Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

    // When the user clicks on the button, open the modal
btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
if (event.target == modal) {
        modal.style.display = "none";
}
}


//validating functions ------------------------------------------------------
const validateEmail = (event) => {
    const regEx = /^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/

    if (regEx.test(event.target.value))
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid email"
}

const validatePassword = (event) => {
    const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d\S]{8,}$/

    if (regEx.test(event.target.value))
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid password"
}


const validateOnSubmit = () => {
    var spans = document.getElementsByTagName("span");
    var isEmpty = true;

    for (var i = 0; 1 < spans.length; i++) {
        if (spans[i].textContent.trim() !== "") {
            isEmpty = false;
            break;
        }
    }

    if (isEmpty == false) {
        return false;
    }

    return true;
}
