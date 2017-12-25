(function ($) {
    $(document).ready(function () {
        $("#nextStageBtn").click(function () {
            var numOfPictures = $("#picNum").val();
            var picTheme = $("#picTheme").val();
            var winnerPic = $("#winnerMethod").val();
            var correctAnswers = 0;
            if (numOfPictures == document.getElementById('picNum').options[2].text) {
                correctAnswers++;
            }
            if (picTheme == document.getElementById('picTheme').options[1].text) {
                correctAnswers++;
            }
            if (winnerPic == document.getElementById('winnerMethod').options[2].text) {
                correctAnswers++;
            }
            if (correctAnswers < 3) {
                alert("You have answered correctly " + correctAnswers + " out of 3 questions.\nPlease Try again.\n"
                   + "You can always go back to the previous page by clicking the 'Back' button\n")
                    
            }

        });

    });
})(jQuery);
