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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.ClearBackground(58, 105, 61);
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Make player character
            Draw.SetFillColor(171, 3, 3);
            //Make Head
            Draw.Rectangle(340, 480, 50, 40);
            
            //Make Player Body
            Draw.Rectangle(350, 530, 30, 40);
        }
    }

}
