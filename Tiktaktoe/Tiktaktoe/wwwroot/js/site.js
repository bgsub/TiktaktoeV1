// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var fullWidth = window.innerWidth;
var fullHeight = window.innerHeight;


function getRandomPositions() {
    let randomX = document.getElementById("random_x");
    let randomO = document.getElementById("random_o");
    var leftX = Math.round(Math.random() * fullWidth) + 'px';
    var leftO = Math.round(Math.random() * fullWidth) + 'px';
    var topX = Math.round(Math.random() * fullHeight) + 'px';
    var topO = Math.round(Math.random() * fullHeight) + 'px';
    randomX.style.right = leftX;
    randomX.style.top = topX;
    randomO.style.right = leftO;
    randomO.style.top = topO;
};
