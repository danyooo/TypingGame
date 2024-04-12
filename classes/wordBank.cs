
// add System Usage to use "Random" in the code.
using System;
//import graphics libraries to use graphics
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
// WordBank class
namespace TypingGame{
  class wordBank{
// Empty word array that contains the set of words for an object
    // would be overrided by whatever object inherits it 
string[] words = { "test", "waaa", "beep"};
//add a string that would contain the chosen random word
string chosenWord;
//add a value to convert the random int chosen and set the value to the chosen word
int randomVal;
// add a instance of random to choose a random thing from the array list
static Random rnd = new Random();
//method to choose a random word from wordbank array
public string chooseWord(){
    //set the list size to the array length
int listSize = this.words.Length;
// make ChosenWord = a random value in the list
 randomVal = rnd.Next(0,listSize);
 chosenWord = this.words[randomVal];
// return the chosen word after this is called
return(chosenWord);
Debug.WriteLine("test");

}

// Method to display word
public void displayText(SpriteBatch spriteBatch,SpriteFont font,  string text,int posX,int posY){
    spriteBatch.DrawString(font,this.chosenWord,new Vector2(posX,posY),Color.Black);
}
}
//example usage of function -> testBank.displayText(_spriteBatch,font,"I'm testing!", 36,30);
}