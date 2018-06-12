function formInputs() {
    var text = "";
    var x = document.getElementById("registrationForm");
    var i;

    for (i = 0; i < 3; i++) { // Stopping at 3 elements to avoid hitting radio buttons
        text += x.elements[i].value + "<br>";
    }
    document.getElementById("output").innerHTML = text;
}

function validateForm() {
    var firstName = document.forms["registrationForm"]["firstname"].value;
    var lastName = document.forms["registrationForm"]["lastname"].value;
    var age = document.forms["registrationForm"]["age"].value;

    if (firstName == "") {
        alert("First name must have a value");
        return false;
    }
    else if (lastName == "") {
        alert("Last name must have a value");
        return false;
    }
    else if (age == "") {
        alert("Age must have a value");
        return false;
    }
}