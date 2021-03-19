"use strict";

// Get expander buttons 
const expanderBtn = document.getElementsByClassName("expanderBtn");

for (let i = 0; i < expanderBtn.length; i++) {

    // Add event listener
    expanderBtn[i].addEventListener("click", function () {

        let textExpand = this.nextElementSibling;

        // Show text if not visible when user click button
        if (textExpand.style.display === "block") {
            textExpand.style.display = "none";

            this.setAttribute("aria-expanded", "false");

            this.firstElementChild.classList.remove("fa-chevron-up");
            this.firstElementChild.classList.add("fa-chevron-right");

            // Hide text if visible when user click button
        } else {
            textExpand.style.display = "block";

            this.setAttribute("aria-expanded", "true");

            this.firstElementChild.classList.remove("fa-chevron-right");
            this.firstElementChild.classList.add("fa-chevron-up");
        }
    })
}