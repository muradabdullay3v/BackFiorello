function myFunction() {
    var x = document.getElementById("sidebar");
    if (x.className === "sidebar close") {
      x.className = "sidebar opened";
    } else {
      x.className = "sidebar close";
    }
  }

  var side_buttons = document.querySelectorAll(".side-dropdown_button");
  [...side_buttons].forEach(btn =>{
    btn.onclick = function () {
      console.log(btn.nextElementSibling);
      if (btn.nextElementSibling.className === "side-dropdown-content") {
        btn.nextElementSibling.className += " opened";
      } else {
        btn.nextElementSibling.className = "side-dropdown-content";
      }
    };
  });

  var sub_side_buttons = document.querySelectorAll(".sub_side-dropdown_button");
  [...sub_side_buttons].forEach(btn =>{
    btn.onclick = function () {
      console.log(btn.nextElementSibling);
      if (btn.nextElementSibling.className === "sub_side-dropdown-content") {
            btn.nextElementSibling.className += " opened";
          } 
      else{
            btn.nextElementSibling.className = "sub_side-dropdown-content";
          }
    };
  });

function closeside() {
    var x = document.getElementById("sidebar");
    if (x.className === "sidebar opened") {
      x.className = "sidebar close";
    } else{
      x.className = "sidebar opened";
    }
  }


  function cat_drop(){
    var x = document.getElementById("categories_content");
    if (x.className === "categories_content") {
      x.className += " opened";
    } else {
      x.className = "categories_content";
    }
  }

var nav = document.getElementById("myTopnav");
var btns = nav.getElementsByClassName("dropdown_button");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function() {
  var current = document.getElementsByClassName("active");
  if (current.length > 0) { 
    current[0].className = current[0].className.replace(" active", "");
  }
  this.className += " active";
  });
}


var dots = document.getElementById("dots");
var btns = dots.getElementsByClassName("fa-circle");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function() {
  var current = document.getElementsByClassName("working");
  if (current.length > 0) { 
    current[0].className = current[0].className.replace(" working", "");
  }
  this.className += " working";
  });
}


filterSelection("alls");
function filterSelection(c) {
  var x, i;
  x = document.getElementsByClassName("filter-item");
  if (c == "all") c = "";
  for (i = 0; i < x.length; i++) {
    RemoveClass(x[i], "show");
    if (x[i].className.indexOf(c) > -1) AddClass(x[i], "show");
  }
}

function AddClass(element, name) {
  var i, arr1, arr2;
  arr1 = element.className.split(" ");
  arr2 = name.split(" ");
  for (i = 0; i < arr2.length; i++) {
    if (arr1.indexOf(arr2[i]) == -1) {element.className += " " + arr2[i];}
  }
}

function RemoveClass(element, name) {
  var i, arr1, arr2;
  arr1 = element.className.split(" ");
  arr2 = name.split(" ");
  for (i = 0; i < arr2.length; i++) {
    while (arr1.indexOf(arr2[i]) > -1) {
      arr1.splice(arr1.indexOf(arr2[i]), 1);     
    }
  }
  element.className = arr1.join(" ");
}

var btnContainer = document.getElementById("filter_btns");
var btns = btnContainer.getElementsByClassName("filter-btn");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function(){
    var current = document.getElementsByClassName("active_filter");
    current[0].className = current[0].className.replace(" active_filter", "");
    this.className += " active_filter";
  });
}
var btnContainer = document.getElementById("filter_btns");
var btns = btnContainer.getElementsByClassName("filter-btn");
for (var i = 0; i < btns.length; i++) {
  btns[i].addEventListener("click", function(){
    var current = document.getElementsByClassName("active_filters");
    current[0].className = current[0].className.replace(" active_filters", "");
    this.className += " active_filters";
  });
}

$(document).ready(function(){
  $('.slick-carousel-items').slick({
        dots: false,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        adaptiveHeight: true,
        autoplay: true,
        autoplaySpeed: 4500,
        cssEase: 'linear',
        arrows: false,
  });
});

let addBtns = document.querySelectorAll(".fltr_btn button");
var totalvalue = 0;
[...addBtns].forEach(button=>{
  button.onclick = function() {
    let counter = 1;
    let h5 = button.parentNode.parentNode.querySelector("h5").innerText;
    let price = button.innerText.substr(1);
    let basket = document.getElementById("basket");
    let items = document.querySelectorAll(".cart-item");
    let product = `<div class="cart-item">
                        <h5>${h5}</h5>
                        <h6 class="cart-item_price"><span>${counter}</span> x <p>$${price}</p></h6>
                        <button class = "button" onclick="DeleteRow(this)"><i class="fa-solid fa-xmark"></i></button>
                    </div>`;
                    [...items].forEach(item => {
                      if (item.innerHTML.includes(h5)) {
                        let current_count = parseInt(item.querySelector("span").innerText) + 1;
                        item.querySelector("h6 span").innerText = current_count;
                      }
                    });
                    if (basket.innerHTML.includes(h5)) {
                      console.log("ok");
                    }
                    else{
                      basket.innerHTML += product;
                    }
    var total = `<h3 class = "total">Total : $<span>${totalvalue+price}</span></h3>`;
                    if(basket.innerText.includes("Total")){
                      parseInt(basket.querySelector("h3 span").innerText) += parseInt(price);
                      console.log("Sol");
                    }
                    else{
                      basket.innerHTML += total;
                    }
                    var cart = document.querySelector("#basket").innerHTML;
                    localStorage.setItem("basket", JSON.stringify(cart));
                    current_cart = JSON.parse(localStorage.getItem("basket"));
                    document.getElementById("no_products").style.display = "none";
  };
});

var current_cart = JSON.parse(localStorage.getItem("basket"));
if (current_cart !== null) {
  basket.innerHTML = current_cart;
}
else if(current_cart === null){
  basket.innerHTML = '<p id="no_products">No products in the cart.</p>';
}


function DeleteRow(button) {
  var p=button.parentNode;
      p.parentNode.removeChild(p);
      cart = document.querySelector("#basket").innerHTML;
      localStorage.setItem("basket", JSON.stringify(cart));
      current_cart = JSON.parse(localStorage.getItem("basket"));
      if(current_cart == "<p id=\"no_products\" style=\"display: none;\">No products in the cart.</p>"){
        basket.innerHTML = '<p id="no_products">No products in the cart.</p>';
        document.getElementById("no_products").style.display = "block";
        console.log("Salam");
        cart = document.querySelector("#basket").innerHTML;
        localStorage.setItem("basket", JSON.stringify(cart));
      }
 }