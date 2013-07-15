using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Draughts
{
    interface GameObject
    {
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
        void Update(GameTime gameTime);
    }
}
