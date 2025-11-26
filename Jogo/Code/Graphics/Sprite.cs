using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jogo
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 position;

        // Novo: Região da imagem que você quer desenhar
        public Rectangle sourceRectangle;

        public Sprite(Texture2D texture, Vector2 position, Rectangle sourceRectangle)
        {
            this.texture = texture;
            this.position = position;
            this.sourceRectangle = sourceRectangle;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White);
        }
    }
}
