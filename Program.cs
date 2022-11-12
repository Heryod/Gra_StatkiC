using System;

using SFML.Graphics;
using SFML.Window;

namespace UltimateIssack
{
    class Program
    {
        const int WIDTH = 1336;
        const int HEIGHT = 768;
        const string TITLE = "SHMUP";
        static void Main()
        {
            VideoMode mode = new VideoMode(WIDTH,HEIGHT);
            RenderWindow window = new RenderWindow(mode, TITLE);
            window.SetFramerateLimit(60);
            window.Closed += (sender, args) => window.Close();


            Player player = new Player();

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Blue);

                // GRACZ, poruszanie
                player.Update();
                // GRACZ, wyświetlanie
                player.Draw(window);


                window.Display();
            }
        }
    }
}