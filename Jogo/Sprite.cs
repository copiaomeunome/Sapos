using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
namespace Jogo
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 position;
        public Sprite(Texture2D texture , Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }
    }
}