using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame___Topic_2___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture, rectTexture;

        Rectangle circleRect;

        SpriteFont textFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            circleRect = new Rectangle(100, 100, 200, 300);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            circleTexture = Content.Load<Texture2D>("circle");
            rectTexture = Content.Load<Texture2D>("rectangle");

            textFont = Content.Load<SpriteFont>("TextFont");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);


            _spriteBatch.Begin();


            _spriteBatch.Draw(circleTexture, circleRect, Color.Plum);
            _spriteBatch.Draw(rectTexture, new Rectangle(20, 200, 400, 200), Color.MediumBlue);

            _spriteBatch.DrawString(textFont, "PONG", new Vector2(300, 50), Color.Aqua);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
