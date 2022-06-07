#region Usings
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using XNATests.Classes.Game;
using XNATests.Classes.Common;
using XNATests.Classes.Utilities;
using System;
#endregion
namespace XNATests
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;
        private Player player = new Player(new Vector2(50, 50));
        private List<GameObject> objects = new List<GameObject>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Arial");
            
            LoadLevel();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Input.Update();
            UpdateAllGameObjects();
            Console.WriteLine($"{player.position}");
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
             DrawAllGameObjects();
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        public void LoadLevel()
        {
            objects.Add(player);

            LoadAllGameObjects();
        }

        public void LoadAllGameObjects()
        {
            for(int i = 0; i <= objects.Count - 1; i++)
            {
                objects[i].Initialize();
                objects[i].Load(Content);
            }
        }
        public void UpdateAllGameObjects()
        {
            for (int i = 0; i <= objects.Count - 1; i++)
            {
                objects[i].Update(objects);
            }
        }
        public void DrawAllGameObjects()
        {
            for (int i = 0; i <= objects.Count - 1; i++)
            {
                objects[i].Draw(_spriteBatch);
            }
        }
    }
}
