document.addEventListener("DOMContentLoaded", function () {
    const section = document.querySelector(".section-2");
    const scrollStep = 400;

    function moveCarousel(direction) {
        section.scrollLeft += direction * scrollStep;
    }

    document.querySelector(".prev").addEventListener("click", function () {
        moveCarousel(-1);
    });

    document.querySelector(".next").addEventListener("click", function () {
        moveCarousel(1);
    });
});
