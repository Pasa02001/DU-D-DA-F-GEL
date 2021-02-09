using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Enemy : BaseClass
    {

        public Enemy(Texture2D texture, Vector2 texturePos) : base(texture, texturePos)
        {
            hitbox.Size = new Point(40, 40);
        }
        public override void Update()
        {
            texturePos.X -= 10;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Assets.Bomb, new Rectangle((int)texturePos.X, (int)texturePos.Y, hitbox.Height, hitbox.Width), Color.White);
        }
    }
}
