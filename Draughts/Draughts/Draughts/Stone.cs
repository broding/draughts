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
        public Vector2 boardPosition;
        public bool alive;
        public Team team;

        private Texture2D texture;

        public Stone(Vector2 boardPosition, Team team)
        {
            this.team = team;
            this.alive = true;
            this.boardPosition = boardPosition;
            this.position = new Vector2();
            this.texture = team == Team.WHITE ? Game.ContentManager.Load<Texture2D>("piece_white") : Game.ContentManager.Load<Texture2D>("piece");
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, new Vector2(Core.BOARD_POSITION.X + Core.BOARD_SIZE.X * boardPosition.X, Core.BOARD_POSITION.Y + Core.BOARD_SIZE.Y * boardPosition.Y), Color.White);
        }

        public void Update(GameTime gameTime)
        {
        }
    }
}
