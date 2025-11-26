using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jogo.World
{
    public abstract class Scene
    {
        protected Game1 game;

        public Scene(Game1 game)
        {
            this.game = game;
        }

        public abstract void Load();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
