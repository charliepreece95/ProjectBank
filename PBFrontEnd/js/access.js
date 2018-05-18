// Written by Ashley Redman
//
// Document written for use of changing the fontSize of html elements
//

// This function will increase the font-size of the p tag by 1
function	fontLarger() {
    var x = document.getElementsByTagName("P");
    var i;
    for (i = 0; i < x.length; i++) {
        x[i].style.fontSize = "larger";
    }
}

// This function will reduce the font-size of the p tag by 1
function 	fontSmaller() {
    var x = document.getElementsByTagName("P");
    var i;
    for (i = 0; i < x.length; i++) {
        x[i].style.fontSize = "small";
    }
}


// Standard reset to default function
function 	fontReset() {
    var x = document.getElementsByTagName("P");
    var i;
    for (i = 0; i < x.length; i++) {
        x[i].style.fontSize = "100%";
    }
}

// these functions below provide a on lick confirm box

function reinstateConfirm() {
    confirm("Are you sure you wish to REINSTATE this Staff Member?");
}

function deletePermConfirm() {
    confirm("Are you sure you wish to PERMANENTLY delete this Staff Member?")
}

function saveNewConfirm() {
    confirm("Are you sure you want to ADD this Staff Member?")
}

function UpdateConfirm() {
    confirm("Are you sure you want to UPDATE this Staff Member?")
}



// here


//Archive company Onclick event
function ArchiveCompanyConfirm() {
    confirm("Do you want to Archive this Company?");
}

//Add company onClick event
function SubmitAddCompanyConfirm() {
    confirm("Do you want to Add this Company?");
}

//Edit company onClick event
function SubmitEditCompanyConfirm() {
    confirm("Do you want to Edit this Company?");
}

//Delete company onClick event
function SubmitDeleteCompanyConfirm() {
    confirm("Do you want to Delete this Company?");
}

//Reinstate company onClick event
function SubmitReinstateCompanyConfirm() {
    confirm("Do you want Reinstate this Company?");
}
