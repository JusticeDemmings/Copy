// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        float x1 = 200;
        float y1 = 200;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

            Window.SetSize(800, 600);
            Window.ClearBackground(58, 105, 61);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Make Wolf
            //Inside of ears
            Draw.SetFillColor(Color.Red);
            Draw.Triangle(350, 30, 350, 60, 330, 60);
            Draw.Triangle(420, 30, 440, 60, 420, 60);

            //Wolf Head
            Draw.SetFillColor(Color.Black);
            Draw.Triangle(350, 30, 370, 60, 350, 60);
            Draw.Triangle(420, 30, 420, 60, 400, 60);
            Draw.Rectangle(330, 60, 110, 10);
            Draw.Square(330, 70, 10);
            Draw.Square(430, 70, 10);
            Draw.Triangle(330, 80, 340, 80, 330, 90);
            Draw.Triangle(430, 80, 440, 80, 440, 90);
            Draw.Triangle(330, 60, 330, 80, 310, 80);
            Draw.Triangle(440, 60, 460, 80, 440, 80);
            Draw.Triangle(330, 80, 330, 100, 310, 100);
            Draw.Triangle(440, 80, 460, 100, 440, 100);
            Draw.Triangle(330, 100, 330, 120, 310, 120);
            Draw.Triangle(440, 100, 460, 120, 440, 120);
            Draw.Triangle(330, 120, 330, 130, 320, 130);
            Draw.Triangle(440, 120, 450, 130, 440, 130);
            Draw.Triangle(330, 100, 340, 110, 330, 110);
            Draw.Triangle(440, 100, 440, 110, 430, 110);
            Draw.Rectangle(330, 110, 10, 30);
            Draw.Rectangle(430, 110, 10, 30);
            Draw.Triangle(340, 120, 350, 130, 340, 130);
            Draw.Triangle(430, 120, 430, 130, 420, 130);
            Draw.Rectangle(340, 130, 10, 30);
            Draw.Rectangle(420, 130, 10, 30);
            Draw.Triangle(330, 140, 340, 140, 340, 150);
            Draw.Triangle(430, 140, 440, 140, 430, 150);
            Draw.Triangle(350, 140, 360, 150, 350, 150);
            Draw.Triangle(420, 140, 420, 150, 410, 150);
            Draw.Square(350, 150, 10);
            Draw.Square(410, 150, 10);
            Draw.Triangle(350, 160, 350, 170, 340, 160);
            Draw.Triangle(420, 160, 430, 160, 420, 170);
            Draw.Square(350, 160, 10);
            Draw.Square(410, 160, 10);
            Draw.Triangle(360, 160, 370, 170, 360, 170);
            Draw.Triangle(410, 160, 410, 170, 400, 170);
            Draw.Quad(370, 170, 400, 170, 390, 180, 380, 180);

            //Wolf Face

            //Set WASD movement controls for player
            if (Input.IsKeyboardKeyDown(KeyboardKey.W) == true)
            {
                //If it is, then:
                y -= 100 * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.A) == true)
            {
                //If it is, then:
                x -= 100 * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S) == true)
            {
                //If it is, then:
                y += 100 * Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.D) == true)
            {
                //If it is, then:
                x += 100 * Time.DeltaTime;
            }

            //Make player
            Draw.SetFillColor(171, 3, 3);
            //Make Head
            Draw.Rectangle(340, 480, 50, 40);
            Draw.Quad(350, 470, 380, 470, 390, 480, 340, 480);
            Draw.Quad(340, 520, 390, 520, 380, 530, 350, 530);

            //Make player body
            Draw.Rectangle(350, 530, 30, 40);
        }
    }

}
