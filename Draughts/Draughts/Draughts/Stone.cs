using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Draughts
{
    class Stone : GameObject
    {
        public Vector2 position;

        private Texture2D texture;

        public Stone()
        {
            position = new Vector2();
            texture = Game.ContentManager.Load<Texture2D>("firefox");
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}
