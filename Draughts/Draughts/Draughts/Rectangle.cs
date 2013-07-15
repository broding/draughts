using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Draughts
{
    class Rectangle : GameObject
    {
        public Color color;
        public Vector2 size;
        public Vector2 position;

        private Texture2D texture;

        public Rectangle(Color color, Vector2 size)
        {
            this.color = color;
            this.size = size;

            texture = new Texture2D(Game.Graphics, 1, 1);
            texture.SetData(new[] { color });
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y), Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}
