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

let rejectButton = document.querySelectorAll(".rejectButton");

rejectButton.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();

    let url = btn.getAttribute("href")

    Swal.fire({
        title: 'Are you sure?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, reject it!'
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


let statusBtn = document.querySelectorAll(".statusBtn");

statusBtn.forEach(btn => btn.addEventListener("click", function (e) {
    e.preventDefault();
}));

//let plusbtn1 = document.querySelectorAll('#plusBtn1')
//let div1 = document.getElementById('div1');
//let count1 = 1;
//let id = 1;

//plusbtn1.forEach(btn => btn.addEventListener("click", function (e) {
//    console.log("ok");
//    div1.innerHTML +=
//        `< input id="${id + 1}" type = "text" class="form-control" placeholder = "Certification"/>`;
//    id += 1;
//    count1++;
//}));

//function get() {
//    let element = document.getElementById(`${id}`);
//    let length = element.value.length;
//    alert(length);
//    if (length > 0) {
//        addForm();
//    }
//}