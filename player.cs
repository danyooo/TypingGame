// Player Class
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TypingGame{
class Player{
// Contains Resources variable(lives)
int Resources;
// Contains empty string "name"
public string name = "";
// Conains int "Score" - begins at 0
int score = 0;
// Contains DamageTaken -- Once hitting 2, you lose the game
int Damagetaken = 0;
// create a variable to set keyinputs to
char keyInput;
// Contains Method to read player's inputs
 public void readInput()
    {
        //  ConsoleKeyInfo is the only variable that can take an input from the 'Console.ReadKey' method
        ConsoleKeyInfo keyPress = Console.ReadKey();
        // Set the keyInput value to the key that was pressed
        keyInput = keyPress.KeyChar;
    
    }
// Contains method to choose name IF the screen is on nameselection menu
public void selectName(List<char> listName)
    {

        listName.Add(this.keyInput);
        // If enter is pressed..
        if (this.keyInput == (char)(13))
        {

            //  Convert & Merge each character typed into one string to form a                       name
            this.name = string.Concat(listName);
            Console.WriteLine("You pressed enter! \n" + "Your name is " + this.name);
            //
        }
    }
// Contains method to check if player's inputs match with repair keywords
}
}