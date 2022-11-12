using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace UltimateIssack
{
    class Background
    {
        private Sprite sprite;

        public const float PLAYER_SPEED = 4f;
        private Vector2f position = new Vector2f(100, 100);
        public Background()
        {
            Texture texture = new Texture("C:\\Users\\13-19\\Desktop\\UltimateIssack\\UltimateIssack\\media\\Hobbit - Idle1.png");
            sprite = new Sprite();
            sprite.Texture = texture;
        }
        public void Draw(RenderWindow _window)
        {
            _window.Draw(sprite);
        }
       
        public void Update()
        {
           

        }
    }
}
