var nav1 = document.getElementById("nav1");
var nav2 = document.getElementById("nav2");
var nav3 = document.getElementById("nav3");
var nav4 = document.getElementById("nav4");
var nav5 = document.getElementById("nav5");
var nav6 = document.getElementById("nav6");
//var nav1 = document.getElementById("nav1");
//var nav1 = document.getElementById("nav1");

function CheckNav() {
    var path = window.location.pathname;
    var page = path.split("/").pop();
    switch (page) {
        case "Index":
            nav1.className = "nav-item active";
            nav2.className = "nav-item"
            nav3.className = "nav-item"
            nav4.className = "nav-item"
            nav5.className = "nav-item"
            nav6.className = "nav-item"
        case "AddStudent":
            nav1.className = "nav-item";
            nav2.className = "nav-item active"
            nav3.className = "nav-item"
            nav4.className = "nav-item"
            nav5.className = "nav-item"
            nav6.className = "nav-item"
            break;
        case "ViewStudent":
            nav1.className = "nav-item";
            nav2.className = "nav-item"
            nav3.className = "nav-item active"
            nav4.className = "nav-item"
            nav5.className = "nav-item"
            nav6.className = "nav-item"
            break;
        case "GetStudent":
            nav1.className = "nav-item";
            nav2.className = "nav-item"
            nav3.className = "nav-item"
            nav4.className = "nav-item active"
            nav5.className = "nav-item"
            nav6.className = "nav-item"
            break;

        case "MarkEntry":
            nav1.className = "nav-item";
            nav2.className = "nav-item"
            nav3.className = "nav-item"
            nav4.className = "nav-item"
            nav5.className = "nav-item active"
            nav6.className = "nav-item"
            break;
        case "ViewMark":
            nav1.className = "nav-item";
            nav2.className = "nav-item"
            nav3.className = "nav-item"
            nav4.className = "nav-item"
            nav5.className = "nav-item"
            nav6.className = "nav-item active"
            break;
    }

}
