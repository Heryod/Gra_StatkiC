using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace UltimateIssack
{
    class Player
    {
        private Sprite sprite;

        public const float PLAYER_SPEED = 4f;
        private Vector2f position = new Vector2f(100, 100);
        public Player()
        {
            Texture texture = new Texture("C:\\Users\\13-19\\Desktop\\UltimateIssack\\UltimateIssack\\media\\issack.png");
            sprite = new Sprite();
            sprite.Texture = texture;

            Vector2u textureSize = texture.Size;
            Vector2u targetSize = new Vector2u(64, 64);
            Vector2f calculateScale = new Vector2f(1, 1);

            calculateScale.X = (float)targetSize.X / (float)textureSize.X;
            calculateScale.Y = (float)targetSize.Y / (float)textureSize.Y;

            sprite.Scale = calculateScale;
        }
        public void Draw(RenderWindow _window)
        {
            _window.Draw(sprite);
        }
        public void keyHandler()
        {
            bool moveLeft = Keyboard.IsKeyPressed(Keyboard.Key.A);
            bool moveRight = Keyboard.IsKeyPressed(Keyboard.Key.D);
            bool moveUp = Keyboard.IsKeyPressed(Keyboard.Key.W);
            bool moveDown = Keyboard.IsKeyPressed(Keyboard.Key.S);

            bool isMove = moveLeft || moveRight || moveUp || moveDown;

            if (isMove)
            {
                if (moveLeft && position.X > 0) position.X -= PLAYER_SPEED;
                if (moveRight && position.X < 1336) position.X += PLAYER_SPEED;
                if (moveUp && position.Y > 0) position.Y -= PLAYER_SPEED;
                if (moveDown && position.Y < 768) position.Y += PLAYER_SPEED;
            }
        }
        public void Update()
        {
            this.keyHandler();
            this.sprite.Position = position;

        }
    }
}
