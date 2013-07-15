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
        private Vector2 BOARD_POSITION = new Vector2(100, 100);
        private Vector2 BOARD_SIZE = new Vector2(60, 60);
        private List<GameObject> gameObjects;

        public Core()
        {
            gameObjects = new List<GameObject>();

            //gameObjects.Add(new Stone());

            Color boardColor = Color.White;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Rectangle boardPiece = new Rectangle(boardColor, BOARD_SIZE);
                    boardPiece.position = new Vector2(BOARD_POSITION.X + x * BOARD_SIZE.X, BOARD_POSITION.Y + y * BOARD_SIZE.Y);
                    gameObjects.Add(boardPiece);

                    if(x != 9)
                        boardColor = boardColor == Color.White ? Color.Brown : Color.White;
                }
            }
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
