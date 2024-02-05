
document.getElementById('btnSwitch').addEventListener('click',()=>{
    if (document.documentElement.getAttribute('data-bs-theme') == 'light') {
        document.documentElement.setAttribute('data-bs-theme','dark')
        
    }
    else {
        document.documentElement.setAttribute('data-bs-theme','light')
    }

    
})

$(function () {
    $('#picker').datetimepicker({
        format: 'MM/DD/YYYY',
        useCurrent :false
    });
});


// Phone number droupdown
var input = document.querySelector(".phone");
window.intlTelInput(input, {
    separateDialCode: true,
    preferredCountries: ["in"]
});
var input1 = document.querySelector(".phone1");
window.intlTelInput(input1, {
    separateDialCode: true,
    preferredCountries: ["in"]
});


