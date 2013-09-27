using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SquaresDemo
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Random rand = new Random();
        int number;
        Texture2D squareTexture1;
        Rectangle currentSquare1;
        Texture2D squareTexture2;
        Rectangle currentSquare2;
        Texture2D squareTexture3;
        Rectangle currentSquare3;
        Texture2D squareTexture4;
        Rectangle currentSquare4;
        Texture2D squareTexture5;
        Rectangle currentSquare5;
        Color[] colors = new Color[5] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple};
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            squareTexture1 = Content.Load<Texture2D>(@"square2");
            squareTexture2 = Content.Load<Texture2D>(@"square2");
            squareTexture3 = Content.Load<Texture2D>(@"square2");
            squareTexture4 = Content.Load<Texture2D>(@"square2");
            squareTexture5 = Content.Load<Texture2D>(@"square2");

            

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            currentSquare1 = new Rectangle(
                rand.Next(0, this.Window.ClientBounds.Width - 25),
                rand.Next(0, this.Window.ClientBounds.Height - 25),
                25, 25);
            currentSquare2 = new Rectangle(
                rand.Next(0, this.Window.ClientBounds.Width - 25),
                rand.Next(0, this.Window.ClientBounds.Height - 25),
                25, 25);
            currentSquare3 = new Rectangle(
                rand.Next(0, this.Window.ClientBounds.Width - 25),
                rand.Next(0, this.Window.ClientBounds.Height - 25),
                25, 25);
            currentSquare4 = new Rectangle(
                rand.Next(0, this.Window.ClientBounds.Width - 25),
                rand.Next(0, this.Window.ClientBounds.Height - 25),
                25, 25);
            currentSquare5 = new Rectangle(
                rand.Next(0, this.Window.ClientBounds.Width - 25),
                rand.Next(0, this.Window.ClientBounds.Height - 25),
                25, 25);


            //Square Color
            //Random rnd = new Random();
            //int number = rnd.Next(1, 5);
           // base.Update(gameTime);
        }

        

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);
            spriteBatch.Begin();
            spriteBatch.Draw(
                squareTexture1,
                currentSquare1,
                colors[1]);
                spriteBatch.End();

                spriteBatch.Begin();
                spriteBatch.Draw(
                    squareTexture2,
                    currentSquare2,
                    colors[1]);
                spriteBatch.End();

                spriteBatch.Begin();
                spriteBatch.Draw(
                    squareTexture3,
                    currentSquare3,
                    colors[2]);
                spriteBatch.End();

                spriteBatch.Begin();
                spriteBatch.Draw(
                    squareTexture4,
                    currentSquare4,
                    colors[3]);
                spriteBatch.End();

                spriteBatch.Begin();
                spriteBatch.Draw(
                    squareTexture5,
                    currentSquare5,
                    colors[4]);
                spriteBatch.End();

            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}
