function setupCollapsibleChevron(classname) {
    var coll = document.getElementsByClassName(classname);
    var i;

    for (i = 0; i < coll.length; i++) {
        if (coll[i].getAttribute('listener') !== 'true') {
            coll[i].setAttribute('listener', 'true');
            coll[i].addEventListener("click", function () {

                var icon = this.querySelector("span");
                icon.classList.toggle('oi-plus');
                icon.classList.toggle('oi-minus');
                this.classList.toggle("active");

                var content = this.nextElementSibling;
                if (content.style.display === "block") {
                    content.style.display = "none";
                } else {
                    content.style.display = "block";
                }

            });

        }
    }
}
function CollapsibleExpand(classname) {
    var coll = document.getElementsByClassName(classname);
    var i;

    for (i = 0; i < coll.length; i++) {

        var icon = coll[i].querySelector("span");
        if (icon.classList.contains('oi-plus')) {
            icon.classList.toggle('oi-plus');
            icon.classList.toggle('oi-minus');
            coll[i].classList.toggle("active");
        }

        var content = coll[i].nextElementSibling;
        if (content.style.display === "block") {
            
        } else {
            content.style.display = "block";
        }

    }
}

function CollapsibleCollapse(classname) {
    var coll = document.getElementsByClassName(classname);
    var i;

    for (i = 0; i < coll.length; i++) {

        var icon = coll[i].querySelector("span");
        if (icon.classList.contains('oi-minus')) {
            icon.classList.toggle('oi-plus');
            icon.classList.toggle('oi-minus');
            coll[i].classList.toggle("active");
        }

        var content = coll[i].nextElementSibling;
        if (content.style.display === "block") {
            content.style.display = "none";

        } else {
        }

    }
}
