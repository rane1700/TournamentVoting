
function myFunction(event) {
    event.preventDefault();
    var age = $("#age").val()
    var gender = $("#gender").val()
    var education = $("#educationLevel").val()
    localStorage.setItem("age", age);
    localStorage.setItem("gender", gender)
    localStorage.setItem("educationLevel", education);
    window.location.href = "../../Views/PreTesting/PreTestingRanking.html"

}
