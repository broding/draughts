using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Draughts
{
    class Core
    {
        private List<GameObject> gameObjects;

        public Core()
        {
            gameObjects = new List<GameObject>();

            gameObjects.Add(new Stone());
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();

            foreach(GameObject gameObject in gameObjects)
            {
                gameObject.Draw(spriteBatch, gameTime);
            }

            spriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(gameTime);
            }
        }
    }
}
