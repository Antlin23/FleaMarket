//TOGGLE PASSWORD VISABILITY
const passwordInput = document.getElementById('password');
const toggleButton = document.getElementById('togglePassword');
if (toggleButton != null) {
    toggleButton.addEventListener('click', () => {
        if (passwordInput.type === 'password') {
            passwordInput.type = 'text';
            toggleButton.innerHTML = '<i class="fa-solid fa-eye"></i>';
        } else {
            passwordInput.type = 'password';
            toggleButton.innerHTML = '<i class="fa-solid fa-eye-slash"></i>';
        }
    });
}

const productCards = document.getElementsByClassName("modal-parent");

for (let i = 0; i < productCards.length; i++) {
    productCards[i].addEventListener("click", (e) => {
        // Find the closest parent element with the data-modalId attribute
        const card = e.target.closest('.product-card');
        console.log(card);
        if (card) {
            const modalId = card.dataset.modalid; // Get the data-modalId from the product card

            const modal = document.getElementById(modalId); // Get the modal by its ID
            if (modal) {
                modal.style.display = "block"; // Show the modal
            } else {
                console.error("Modal not found for ID:", modalId);
            }
        }
    });
}

// Get the <spans> elements that closes the modal
var spans = document.getElementsByClassName("close");

for (var i = 0; i < spans.length; i++) {
    spans[i].onclick = function () {
        let modals = document.getElementsByClassName("__modal");
        for (const modal of modals) {
            console.log(modal);
            modal.style.display = "none";
        }
    };
}


// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    let modals = document.getElementsByClassName("__modal");

    for (const modal of modals) {
        if (event.target == modal) {
            console.log(modal);
            modal.style.display = "none";
        }
    }
}

//SHOW AND HIDE BTN GROUPS --
const showConfirmationGroup = (btnGroup, btnConfirmationGroup, productId) => {
    //closes all confirmation groups before showing this one
    hideConfirmationGroup();

    if (productId == null) {
        var btnGroup = document.getElementById(btnGroup);
        var btnConfirmationGroup = document.getElementById(btnConfirmationGroup);
    }
    else {
        var btnGroup = document.getElementById(btnGroup + productId);
        var btnConfirmationGroup = document.getElementById(btnConfirmationGroup + productId);
    }
    btnGroup.classList.add("d-none");
    btnConfirmationGroup.classList.remove("d-none");
}

const hideConfirmationGroup = () => {
    const singleBtnGroups = document.getElementsByClassName("singleBtnGroup");
    const btnConfirmationGroups = document.getElementsByClassName("btnConfirmationGroup");

    // Convert HTMLCollections to arrays for iteration
    const singleBtnArray = Array.from(singleBtnGroups);
    const btnConfirmationArray = Array.from(btnConfirmationGroups);

    // Remove "d-none" class from singleBtnGroups
    singleBtnArray.forEach((singleBtnGroup) => {
        singleBtnGroup.classList.remove("d-none");
    });

    // Add "d-none" class to btnConfirmationGroups
    btnConfirmationArray.forEach((btnConfirmationGroup) => {
        btnConfirmationGroup.classList.add("d-none");
    });

};

document.addEventListener("click", (event) => {
    const clickedElement = event.target;

    if (!clickedElement.classList.contains("show-congroup-btn")) {
        hideConfirmationGroup();
    }
});






//validating functions ----NOT IN USE (i think)---------------------------------------------------------
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
