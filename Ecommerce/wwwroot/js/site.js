// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("icon").addEventListener("click", (e) => {
    document.querySelector(".navbar").style.display = "block";
    document.getElementById("myMenu").style.display = "flex";
    document.getElementById("icon").style.display = "none";
    document.getElementById("myMenu").style.flexDirection = "column";
    document.getElementById("myMenu").style.gap = "30%";
    document.getElementById("myMenu").style.alignItems = "center";
    document.getElementById("myMenu").style.justifyContent = "flex-end";
});

const Plus = document.querySelector('.plus');
const Minus = document.querySelector('.minus');
const Totalnumber = document.querySelector('.number-count');


let count = 0;
Totalnumber.innerHTML = count;
function increment() {
    count = count + 1;
    Totalnumber.innerHTML = count;
}


function decrement() {
    count = count - 1;
    Totalnumber.innerHTML = count;
}
Plus.addEventListener('click', increment)
Minus.addEventListener('click', decrement)