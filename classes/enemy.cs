// add System Usage to use "Random" in the code.
using System;
//import graphics libraries to use graphics
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TypingGame{
// Inherit from the wordBank class
class Enemy : wordBank{

    //override array to conatain weakness
 string[] words = {"cannonball","arrows","sword","spear","dart","sling"};
// speed variable to move towards the player at with this speed
int speed;
// point value upon kill( to add to player's score)
int ScoreValue;




}
}