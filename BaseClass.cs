using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Template
{
    abstract class BaseClass
    {
        protected Texture2D texture;
        protected Vector2 texturePos;
        protected Rectangle hitbox;

        public BaseClass(Texture2D texture, Vector2 texturePos)
        {
            this.texture = texture;
            this.texturePos = texturePos;
        }
        public Rectangle Hitbox
        {
            get => hitbox;

        }
        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);
        
    }
}
