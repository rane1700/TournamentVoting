(function ($) {
    $(document).ready(function () {
        $("#nextStageBtn").click(function () {
            var numOfPictures = $("#picNum").val();
            var picTheme = $("#picTheme").val();
            var winnerPic = $("#winnerPic").val();
            var correctAnswers = 0;
            if (numOfPictures == $("#picNum").option[2].text) {
                correctAnswers++;
            }
            if (picTheme == $("#picTheme").option[1].text) {
                correctAnswers++;
            }
            if (winnerPic == $("#winnerMethod").option[2].text) {
                correctAnswers++;
            }
            if (correctAnswers < 3) {
                alert("You have answered correctly ${correctAnswers} out of 3 questions" + 
                    "Please Try again." +
                    "You can always go back to the previous page by clicking the 'Back' button");
            }

        });

    });
})(jQuery);
