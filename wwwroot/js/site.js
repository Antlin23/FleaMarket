//MODAL POPUPS --
//Delete all products modal
const openDeletProductsModal = () => {
    // Get the modal
    var modal = document.getElementById("deleteAllProductsModal");
    modal.style.display = "block";
}

//See more product info modal
const seeMoreProductInfo = (modalId) => {
// Get the modal
var modal = document.getElementById(modalId);
    modal.style.display = "block";
}

// Get the <spans> elements that closes the modal
var spans = document.getElementsByClassName("close");

for (var i = 0; i < spans.length; i++) {
    spans[i].onclick = function () {
        let modals = document.getElementsByClassName("__modal");
        for (const modal of modals) {
            modal.style.display = "none";
        }
    };
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    let modals = document.getElementsByClassName("__modal");

    for (const modal of modals) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
}


//delete product button --
const showDeleteProductConfirmation = (productId) => {
    var deleteProductConGroup = document.getElementById('deleteProductConGroup-' + productId);
    var deleteBtnGroup = document.getElementById('deleteProductGroup-' + productId);
    deleteBtnGroup.classList.add("d-none");
    deleteProductConGroup.classList.remove("d-none");
}
const closeDeleteProductConfirmation = (productId) => {
    var deleteProductConGroup = document.getElementById('deleteProductConGroup-' + productId);
    var deleteBtnGroup = document.getElementById('deleteProductGroup-' + productId);
    deleteProductConGroup.classList.add("d-none");
    deleteBtnGroup.classList.remove("d-none");
}

//delete all products button --
const showDeleteProductsConfirmation = () => {
    var deleteProductsConGroup = document.getElementById('deleteProductsConGroup');
    var deleteBtnGroup = document.getElementById('deleteProductsGroup');
    deleteBtnGroup.classList.add("d-none");
    deleteProductsConGroup.classList.remove("d-none");
}
const closeDeleteProductsConfirmation = () => {
    var deleteProductsConGroup = document.getElementById('deleteProductsConGroup');
    var deleteBtnGroup = document.getElementById('deleteProductsGroup');
    deleteProductsConGroup.classList.add("d-none");
    deleteBtnGroup.classList.remove("d-none");
}



//validating functions ----NOT IN USE---------------------------------------------------------
const validateText = (event) => {

    document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "Minst 4 tecken"
}

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
