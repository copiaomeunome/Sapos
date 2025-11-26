using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;

namespace Jogo.World
{
    public class Mundo1Scene : Scene
    {
        private TiledMap map;
        private TiledMapRenderer renderer;

        public Mundo1Scene(Game1 game) : base(game) {}

        public override void Load()
        {
            map = game.Content.Load<TiledMap>("Maps/mundo1");
            renderer = new TiledMapRenderer(game.GraphicsDevice, map);
        }

        public override void Update(GameTime gameTime)
        {
            renderer.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            renderer.Draw();
        }
    }
}
