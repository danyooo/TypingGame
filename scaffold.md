game/gamemanager class to reset game after losing / setting new name
{
contains a variable (isGameStarted)
If (isGameStarted == true){
resetting is possible    
}
When the player chooses to reset their name, reset the game
}

!!Could be an interface!!
WordBank class{
Empty word variable(? maybe to push words into. TBD)    
Method to push words into an array of x type
Method to display word
}

Player Class{
Contains Resources variable(lives)
Contains empty string "name"
Conains int "Score" - begins at 0
Contains in DamageTaken -- Once hitting 2, you lose the game
Contains Method to read player's inputs
Contains method to check if player's inputs match with repair keywords
Contains method to choose name IF the screen is on nameselection menu

}
Enemy Class{
Empty String "Weakness" - The keyword that kills this object
empty Speed int - To be set by the enemy
Empty ScoreValue int -- To set and add to players score flatly every time this is killed
Method that would have enemy move towards player // castle with the speed value
method that would check if playerinputs match enemyWeakness to kill this object
method that would determine if enemy reaches castle // player OR when ranged enemies' projectiles hit the castle.. This causes castle health to go down
Method to choose random word out of wordbank class(Set this to weakness)
Method to display weakness above this object

!!What to do when multiple enemies with same weakness? Priority system needed!!
}
Timer class{
time int -- Starts at x amount
Scorevalue int
Method that adds scorevalue to player's score by x every time y amount of time passes
----COULD GO IN ENEMY CLASS----
method that ticks the time down every second
method to spawn enemies every x second with time "barriers" allowing more unique enemies to spawn    
------
Method to display this(time) somewhere on the screen in (minutes:seconds)

----PERSISTENT STORAGE----
Class files here(?)
Wordbank here(?)
Difficulty stored here -- Complexity of words/weaknesses and enemies
Store level tied to players names. This level value would update with whatever the player last completed
Store player score here under players name -- to put on a high score screen

---
DRAW FUNCTION{
Unsure of formatting with MONOGAME...
Loop while gameruning // while game is being played{
Method to draw all graphical components of each object (need to give these objects a variable for this first..)
}

}

Win/Lose conditions{
bool win
if score is greater than x you win!{
 Store player score value   
}
Otherwise // Else{
while !win check if players damagetaken value exceeds 2. if so store players score at time of loss and upload it and prompt lose screen    
}    
}
Progression{
int difficulty // gateway for complexity
if win- Difficulty + y || difficulty X y    
}
}