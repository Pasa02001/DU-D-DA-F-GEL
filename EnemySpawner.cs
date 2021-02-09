using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Template
{
    class EnemySpawner
    {
        private List<Enemy> enemies = new List<Enemy>();
        private float time = 5;
        private float timer = 0;
        private Random rnd = new Random();
        public EnemySpawner(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }
        public void Update(GameTime gameTime)
        {
            if(timer >= time)
            {
                timer -= time;
                int x,y;

                do
                {
                    x = 840;
                    y = rnd.Next(0, 420);
                } while (enemies.Count <= 10);
                enemies.Add(new Enemy(Assets.Bomb, new Vector2(x, y)));
            }

            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

        }
    }
}
