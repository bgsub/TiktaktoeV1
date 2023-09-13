function openAMenu(menuToOpen) {
    let mainMenu = document.getElementById("main-menu");
    let menu = document.getElementById(menuToOpen);
    mainMenu.style.display = "none";
    menu.style.display = "flex";
    menu.style.flexDirection = "column";
}
function backToMainMenu(menuToClose) {
    let mainMenu = document.getElementById("main-menu");
    let menu = document.getElementById(menuToClose);
    menu.style.display = "none";
    mainMenu.style.display = "flex";
    mainMenu.style.flexDirection = "column";
}