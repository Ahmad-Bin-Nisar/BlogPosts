$(document).ready(() => {
    var users;
   // const POSTS_API = 

    // fetch and display posts for the first time

     //fetchposts();

    // updateStats();

    // function to render students available in the array students[]

    //function displaystudents() {
    //    $(".posts-container").empty();

    //    for (let i = 0; i < students.length; i++) {
    //        $(".posts-container").append(makePost(students[i]));
    //    }
    //}

    // function to make a post

    //function makePost(user) {
    //    return `

    //            <div class="post">

    //                <h2>${user.userId}</h2>

    //                <p>${user.firstName + user.lastName}</p>

    //                <p>${user.Email}</p> 

    //            </div>

    //            `;
    //}

    //function displayError(error) {
    //    $(".posts-container").html(
    //        '<div class="error">Some Error has occured!</div>'
    //    );
    //}

    //function fetchposts() {
    //    $.ajax({
    //        method: "GET",

    //        url: POSTS_API,

    //        success: (data) => {
    //            students = data;

    //            displayusers();
    //        },

    //        error: displayError,
    //    });
    //}

    // Function to handle form submission
    $("#userForm").submit(function (event) {
        alert("Hello Bitches")
        event.preventDefault(); // Prevent the default form submission

        // Gather form data
        const formData = {
            firstName: $("#firstName").val(),
            lastName: $("#lastName").val(),
            Email: $("#Email").val()
        };

        // Make an AJAX POST request
        $.ajax({
            type: "POST",
            url: "http://localhost:51238/api/BlogPosts/InsertUser", // Replace this with your actual API endpoint URL
            data: JSON.stringify(formData),
            contentType:"application/json",
            success: function (_data) {
                // Handle successful response from the server
                alert("User added successfully!");
                // You can perform additional actions here, like clearing the form or showing a success message.
            },  
            error: function (error) {
                // Handle error response from the server
                alert("Failed to add user because of: " + error + ". Please try again!");
                // You can perform additional error handling here.
            },
        });
    });
});