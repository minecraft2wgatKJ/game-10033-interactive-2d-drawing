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
            //window settings
            Window.SetSize(400, 400);
            Window.SetTitle("windy day");
            Window.ClearBackground(0, 0, 200);

            //flower stalk
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

            //Wild mustard head
            Draw.SetFillColor(255, 255, 0);
            Draw.Ellipse(200, 200, 150, 150);

            //Wild Mustard Head
            Draw.SetFillColor(0);
            Draw.Arc(200, 220, 90, 90, 0, 180);

            //Left eye
            Draw.SetFillColor(0);
            Draw.Ellipse(160, 175, 25, 25);

            //Right eye
            Draw.SetFillColor(0);
            Draw.Ellipse(240, 175, 25, 25);


            //If statement for different face
            if (Input.IsMouseButtonDown(MouseButton.Left) == true)
            {

                //mustard head 2
                Draw.SetFillColor(255, 255, 0);
                Draw.Ellipse(200, 200, 150, 150);

                //mustard squinty left eye
                Draw.SetFillColor(0);
                Draw.Rectangle(140, 175, 45, 15);

                //mustard squinty right eye
                Draw.SetFillColor(0);
                Draw.Rectangle(220, 175, 45, 15);

                //mustard shut mouth
                Draw.SetFillColor(0);
                Draw.Rectangle(155, 220, 90, 20);

                //wind shapes
                Draw.SetFillColor(76, 83, 95);
                Draw.Rectangle(Input.GetMouseX(), Input.GetMouseY(), 150, 30);
                Draw.SetFillColor(76, 83, 95);
                Draw.Rectangle(Input.GetMouseX() + 50, Input.GetMouseY()+50, 150, 30);
                Draw.SetFillColor(76, 83, 95);
                Draw.Rectangle(Input.GetMouseX()-50, Input.GetMouseY()-50, 150, 30);
            }











        }
    }

}
