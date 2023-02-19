let deleteButton = document.querySelectorAll(".deleteButton");

deleteButton.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href")

    Swal.fire({
        title: 'Are you sure?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            fetch(url)
                .then(res => {
                    if (res.status == 200) {
                        window.location.reload(true)
                    }
                })
        }
    })
}));

let restoreButton = document.querySelectorAll(".restoreButton");

restoreButton.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href")

    Swal.fire({
        title: 'Are you sure?',
        text: "You can see this data in main table!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, restore it!'
    }).then((result) => {
        if (result.isConfirmed) {
            fetch(url)
                .then(res => {
                    if (res.status == 200) {
                        window.location.reload(true)
                    }
                })
        }
    })
}));