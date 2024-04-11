
// add System Usage to use "Random" in the code.
using System;
// WordBank class
 abstract class WordBank{
// Empty word array that contains the set of words for an object
    // would be overrided by whatever object inherits it 
string[] words;
//add a string that would contain the chosen random word
string chosenWord;
//add a value to convert the random int chosen and set the value to the chosen word
int randomVal;
// add a instance of random to choose a random thing from the array list
static Random rnd = new Random();
//method to choose a random word from wordbank array
public string chooseWord(){
    //set the list size to the array length
int listSize = words.Length;
// make ChosenWord = a random value in the list
 randomVal = rnd.Next(0,listSize);
 chosenWord = words[randomVal];
// return the chosen word after this is called
return(chosenWord);

}
// Method to display word
}