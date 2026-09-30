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

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //this the window stuff
            Window.SetSize(400, 400);
            Window.SetTitle("windy day");
            Window.ClearBackground(0, 0, 200);

            // this the flower stalk
            Draw.Rectangle(180, 200, 40, 200);
            Draw.SetFillColor(0, 205, 0);
            Draw.SetLineColor(0);

            // left petal
            Draw.Ellipse(100, 200, 125, 75);
            Draw.SetFillColor(255, 255, 0);

            //right petal
            Draw.Ellipse(300, 200, 125, 75);
            Draw.SetFillColor(255, 255, 0);

            //Bottom petal
            Draw.Ellipse(200, 300, 75, 125);
            Draw.SetFillColor(255, 255, 0);

            // Top Petal
            Draw.Ellipse(200, 100, 75, 125);
            Draw.SetFillColor(255, 255, 0);

            // this is the sunflower
            Draw.Ellipse(200, 200, 150, 150);
            Draw.SetFillColor(0, 205, 0);
            Draw.SetLineColor(0);






        }
    }

}
