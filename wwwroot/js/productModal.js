const productCards = document.getElementsByClassName("modal-parent");
for (let i = 0; i < productCards.length; i++) {
    productCards[i].addEventListener("click", (e) => {
        const card = e.target.closest('.product-card');
        if (card) {
            const modalId = card.dataset.modalid; // Get the data-modalId from the product card

            let modal = document.getElementById(modalId); // Get the modal by its ID
            if (modal) {
                modal.style.display = "block"; // Show the modal
            } else {
                console.error("Modal not found for ID:", modalId);
            }
        }
    });
}

// Get the <spans> elements that closes the modal
let closeSpans = document.getElementsByClassName("close");
for (var i = 0; i < closeSpans.length; i++) {
    closeSpans[i].addEventListener("click", (e) => {
        e.stopPropagation();
        
        let card = e.target.closest('.product-card');

        if (card) {
            const modalId = card.dataset.modalid;
            const modal = document.getElementById(modalId);
            if (modal) {
                modal.style.display = "none";
            } else {
                console.error("Modal not found for ID:", modalId);
            }
        }
    }) 
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    let modals = document.getElementsByClassName("__modal");

    for (const modal of modals) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
}