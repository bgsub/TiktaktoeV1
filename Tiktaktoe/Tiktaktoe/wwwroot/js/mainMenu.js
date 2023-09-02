function displayClassicGameMenu() {
    let mainMenu = document.getElementById("main-menu");
    let classicGame = document.getElementById("classic-menu")
    mainMenu.style.display = "none";
    classicGame.style.display = "flex";
    classicGame.style.flexDirection = "column";
}