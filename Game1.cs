using System;
using System.Collections.Generic; // to use lists
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace TypingGame;

public class Game1 : Game
{
    // set windowWidth & windowHeight
    // create a Player object
 Player player = new Player();
 Enemy testEnemy = new Enemy();
 // Create a list that would contain the letters the player types (to set into a name)
List<char> PlayerName = new List<char>();
// Create a SpriteFont Object ( To load up the font to use for text)
 SpriteFont font;



    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    
    }
    // set window width & height to an easier to manage variable
// int windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
// int windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        testEnemy.chooseWord();
        Console.WriteLine("Help Me!");
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
            //Load the text font
    font = Content.Load<SpriteFont>("gameFont");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        // do this later
// detect player name state
// while(player.name == ""){
// player.readInput();
// player.selectName(PlayerName);
// if(player.name !=""){
//     break;
// }
// }
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
            //draw text
        _spriteBatch.Begin();
_spriteBatch.DrawString(font,"testing",new Vector2(0,0),Color.Black);
// testEn.displayText(_spriteBatch,font,testEn.chosenWord, 36,72);
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
