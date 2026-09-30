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
            //this the window stuff
            Window.SetSize(400, 400);
            Window.SetTitle("windy day");
            Window.ClearBackground(0, 0, 200);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {


            // this the flower stalk
            Draw.SetFillColor(0, 205, 0);
            Draw.Rectangle(180, 200, 40, 200);
            Draw.SetLineColor(0);

            // left petal
            Draw.SetFillColor(255, 255, 0);
            Draw.Ellipse(100, 200, 125, 75);

            //right petal
            Draw.SetFillColor(255, 255, 0);
            Draw.Ellipse(300, 200, 125, 75);

            //Bottom petal
            Draw.SetFillColor(255, 255, 0);
            Draw.Ellipse(200, 300, 75, 125);

            // Top Petal
            Draw.SetFillColor(255, 255, 0); ;
            Draw.Ellipse(200, 100, 75, 125);

            // this is the sunflower head
            Draw.SetFillColor(255, 255, 0);
            Draw.Ellipse(200, 200, 150, 150);
            Draw.SetLineColor(0);

            // this is the mouth of him
            Draw.SetFillColor(0);
            Draw.Arc(200, 220, 90, 90, 0, 180);

            // this will be the left eye please
            Draw.SetFillColor(0);
            Draw.Ellipse(160, 175, 25, 25);

            // yarrrg! It's me right eye!
            Draw.SetFillColor(0);
            Draw.Ellipse(240, 175, 25, 25);












        }
    }

}
