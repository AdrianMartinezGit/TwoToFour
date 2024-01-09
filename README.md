<h1>Two To Four</h1>
Adrian Martinez<br>
1 / 9 / 2024 - 3:04 PM<br>
MiniChallengeTwoToFour - Endpoints<br>
Design an API with 3 Endpoints:<br>
    1. Add 2 Two Numbers<br>
    2. Asking Questions for User (What is your name? [Only Type the Name]) (What time did you wake up? [Only Type the Time])<br>
    3. Greater or Less Than<br>
<br>
Peer Reviewed by Alexander Soria
Review: The program works mostly as intended. I'm just confused as to why HttpPost was used instead of HttpGet for the Controllers. None of the Services have a TryParse to ensure some inputs are integers, and as a result, there is no programming for returning an error message if an invalid input is given. Very nice that each service is in its own folder. It makes the file strucutre a little cleaner. Overall, it's alright, but just needs more to ensure outputs come out correctly.
