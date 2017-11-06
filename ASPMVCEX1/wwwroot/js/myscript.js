function verifyEmail(email) {
    let atposition = email.indexOf("@");
    if (atposition > 0) {
        let dotposition = email.substring(atposition + 1).indexOf(".");
        if (dotposition > 0) {
            return true;
        }
    }

    return false;
}

function verifyPhoneNr(phonenr) {
    let numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    let correct = true;

    for (let i = 0; i < phonenr.length; i++) {
        if (numbers.indexOf(phonenr[i]) === -1)
            correct = false;
    }

    return correct;
}

$(document).ready(function () {
    $("form").submit(function (event) {
        let email = $("#Email").val();
        let phonenr = $("#PhoneNr").val();
        if (email.length <= 0 || phonenr.length <= 0 || verifyEmail(email) === false || verifyPhoneNr(phonenr) === false) {
            alert("Please check input!");
            event.preventDefault();
        }
    });
});