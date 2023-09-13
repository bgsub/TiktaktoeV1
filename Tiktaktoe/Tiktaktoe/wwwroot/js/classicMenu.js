function continueTo(nextView) {
    let classicMenu = document.getElementById("classic-menu");
    let view = document.getElementById(nextView);
    classicMenu.style.display = "none";
    view.style.display = "flex";
    view.style.flexDirection = "column";
}