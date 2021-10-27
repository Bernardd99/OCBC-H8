$(document).ready(function (){

    console.log($('#page-title'))

    console.log(document.getElementById("page-title"))

    $('#page-title').click(function (){
        alert('Clicked')
    })

    $('#submitBtn').click(function(e){
        e.preventDefault()

        let username = $('#username').val()

        alert("Halo, " + username)
    }) 
});