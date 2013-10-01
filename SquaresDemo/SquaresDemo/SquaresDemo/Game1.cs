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
        Rectangle[] squares;
        Color[] colors = new Color[4] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
        Texture2D square;
        
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            squares = new Rectangle[100];
            for (int i = 0; i < 100; i++)
            {
                squares[i] = new Rectangle(rand.Next(0, 800), rand.Next(0, 600), 15, 15);

            }
        }

        public void RandomSquares()
        {
            for (int i = 0; i < squares.Length; i++)
            {
                spriteBatch.Draw(square, squares[i], Color.Yellow);

            }

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

            square = Content.Load<Texture2D>("single_snowflake-69px");
            

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

            for (int i = 0; i < squares.Length; i++)
            {
                if (squares[i].Bottom > 600)
                {
                    squares[i] = new Rectangle(rand.Next(0, 800), -50, 15, 15);
                }

                squares[i].Y += (int)((float)gameTime.ElapsedGameTime.Milliseconds * 0.5f);
            }

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
            GraphicsDevice.Clear("New.jpg");
            spriteBatch.Begin();
            RandomSquares();
            spriteBatch.End();
              
                

            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}
