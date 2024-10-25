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