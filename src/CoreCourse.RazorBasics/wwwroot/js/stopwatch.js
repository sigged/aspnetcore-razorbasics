document.addEventListener("DOMContentLoaded", function () {
    var cacheTimeLeft = 15;

    displaySecondsLeft(cacheTimeLeft);

    var timer = setInterval(function () {
        displaySecondsLeft(--cacheTimeLeft);
        if (cacheTimeLeft <= 0)
            clearInterval(timer);
    }, 1000);
});


function displaySecondsLeft(secondsLeft) {
    var countdownElements = document.querySelectorAll(".countdown");
    countdownElements.forEach(function (element) {
        if (secondsLeft <= 0) {
            element.innerHTML = 'Cache expired! Try refreshing now to see the content change.';
        } else {
            element.innerHTML = '<b>' + secondsLeft + '</b> seconds left before cache expires. Refresh now to prevent this.';
        }
    });
}