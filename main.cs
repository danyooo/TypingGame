using System;
using System.Collections.Generic; // to use lists

class Program{
public static void Main(string[] args){
var Player = new Player();
List<char> PlayerName = new List<char>();
Console.WriteLine("Please enter your name");
while(Player.name == ""){
Player.readInput();
Player.selectName(PlayerName);
if(Player.name !=""){
    break;
}

}

}
}