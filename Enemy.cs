using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Template
{
    class Enemy : BaseClass
    {

        public Enemy(Texture2D texture, Vector2 texturePos, float angle) : base(texture, texturePos, angle)
        {
            hitbox.Size = new Point(40, 40);
            angle = 45;
        }
        public override void Update()
        {
            texturePos.X -= 10;
            
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Assets.Bomb, new Rectangle((int)texturePos.X, (int)texturePos.Y, hitbox.Height, hitbox.Width),null, Color.White, angle, new Vector2(texture.Width/2, texture.Height/2) ,SpriteEffects.None ,0);
        }
    }
}
