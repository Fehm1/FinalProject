let addToBasketBtns = document.querySelectorAll(".addToBasket");

addToBasketBtns.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href");

    fetch(url)
        .then(res => {
            if (res.status == 200) {
                alert("Added to basket!");
            }
            else {
                alert("Error!");
            }
        })
}));

let removeFromBasket = document.querySelectorAll(".removeFromBasket");

removeFromBasket.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href");

    fetch(url)
        .then(res => {
            if (res.status == 200) {
                alert("Removed from basket!");
            }
            else {
                alert("Error!");
            }
        })
}));