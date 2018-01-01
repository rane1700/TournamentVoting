
function sendDataTodb(event) {
    event.preventDefault();
    $("#submitBtn").prop('disabled', true);
    rankingsUrl = "../../api/PreTestingExperimenterRankings"
    $("#loading").show();
    $.ajax({
        url: rankingsUrl,
        type: "POST",
        data: JSON.stringify({
            "Age": parseInt(localStorage.getItem("age")),
            "Gender": localStorage.getItem("gender"),
            "Education": localStorage.getItem("educationLevel"),
            "Image1Rank": parseInt($("#img1Rating").val()),
            "Image2Rank": parseInt($("#img2Rating").val()),
            "Image3Rank": parseInt($("#img3Rating").val()),
            "Image4Rank": parseInt($("#img4Rating").val())
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            $("#loading").hide();
            window.location.href = "../../Views/PreTesting/EndScreen.html"
        },
        error: function () {
            alert("Couldn't add result to data base.")
        }


    });

}
