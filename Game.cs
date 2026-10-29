// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel.Design;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    //Variables for Big Bad Wolf
    float timeBeforeTurning;
    bool isFacingAway;

    //Variables for Rectangle1
    float x1 = 340;
    float y1 = 480;

    //Variable for Rectangle2
    float x2 = 350;
    float y2 = 530;

    //Variables for Trap1
    float x3 = 380;
    float x4 = 390;
    float y3 = 470;

    //Variables for Trap2
    float y4 = 520;
    float y5 = 530;

    Tree[] trees = new Tree[200];

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
        Window.ClearBackground(58, 105, 61);

        //Decrement time remaining
        timeBeforeTurning -= Time.DeltaTime;

        if (isFacingAway == true)
        {
            //If it is, then:
            //Make Big Bad Wolf Facing Away
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Triangle(350, 30, 350, 60, 330, 60);
            Draw.Triangle(420, 30, 440, 60, 420, 60);

            //Wolf Head
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
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
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Rectangle(340, 70, 90, 10);
            Draw.Triangle(340, 80, 340, 90, 330, 90);
            Draw.Square(330, 90, 10);
            Draw.Triangle(340, 100, 340, 110, 330, 100);
            Draw.Rectangle(340, 80, 10, 40);
            Draw.Triangle(350, 80, 360, 80, 350, 90);
            Draw.Triangle(340, 120, 350, 120, 350, 130);
            Draw.Rectangle(350, 110, 10, 30);
            Draw.Triangle(350, 100, 360, 110, 350, 110);
            Draw.Rectangle(360, 110, 10, 50);
            Draw.Triangle(360, 140, 360, 150, 350, 140);
            Draw.Triangle(360, 160, 370, 160, 370, 170);
            Draw.Rectangle(380, 80, 20, 30);
            Draw.Triangle(400, 80, 410, 80, 400, 90);
            Draw.Triangle(400, 100, 410, 110, 400, 110);
            Draw.Rectangle(370, 110, 60, 10);
            Draw.Square(400, 120, 20);
            Draw.Triangle(430, 100, 430, 110, 420, 110);
            Draw.Triangle(420, 120, 430, 120, 420, 130);
            Draw.Triangle(410, 140, 420, 140, 410, 150);
            Draw.Rectangle(370, 140, 40, 10);
            Draw.Rectangle(370, 160, 30, 10);
            Draw.Triangle(400, 160, 410, 160, 400, 170);
            Draw.Square(400, 150, 10);
            Draw.Quad(430, 80, 440, 90, 440, 100, 430, 110);
            Draw.Triangle(420, 80, 430, 80, 430, 90);
            Draw.Triangle(370, 80, 380, 80, 380, 90);
            Draw.Triangle(380, 100, 380, 110, 370, 110);
            Draw.Triangle(370, 130, 380, 140, 370, 140);
            Draw.Triangle(400, 130, 400, 140, 390, 140);

            //Draw Nose
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Rectangle(370, 120, 30, 10);
            Draw.Quad(370, 130, 400, 130, 390, 140, 380, 140);

            //Draw Eyes
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Triangle(360, 80, 360, 90, 350, 90);
            Draw.Triangle(370, 80, 380, 90, 370, 90);
            Draw.Triangle(370, 100, 380, 100, 370, 110);
            Draw.Triangle(350, 100, 360, 100, 360, 110);
            Draw.Square(360, 80, 10);
            Draw.Square(370, 90, 10);
            Draw.Square(360, 100, 10);
            Draw.Square(350, 90, 10);
            Draw.Triangle(410, 80, 410, 90, 400, 90);
            Draw.Triangle(420, 80, 430, 90, 420, 90);
            Draw.Triangle(420, 100, 430, 100, 420, 110);
            Draw.Triangle(400, 100, 410, 100, 410, 110);
            Draw.Square(410, 80, 10);
            Draw.Square(420, 90, 10);
            Draw.Square(410, 100, 10);
            Draw.Square(400, 90, 10);

            //Draw Pupils
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Square(360, 90, 10);
            Draw.Square(410, 90, 10);

            //Draw Mouth
            Draw.SetLineSize(0);
            Draw.SetFillColor(115, 115, 115);
            Draw.Square(380, 150, 10);
            Draw.SetFillColor(115, 115, 115);
            Draw.Square(370, 150, 10);
            Draw.Square(390, 150, 10);
        }

            //Caught Walking Reset

            {
                //Reset Player Position
                //Reset Big Bad Wolf
            }

            //Face Away if Timer Runs Out
            if (timeBeforeTurning <= 0)
            {
                isFacingAway = true;
                timeBeforeTurning = Random.Float(1, 2);
            }

            if (timeBeforeTurning < 0.400f)
            {
             //Make Wolf
             //Inside of ears
             Draw.SetLineSize(0);
             Draw.SetFillColor(242, 116, 198);
             Draw.Triangle(350, 30, 350, 60, 330, 60);
             Draw.Triangle(420, 30, 440, 60, 420, 60);

             //Wolf Head
             Draw.SetLineSize(0);
             Draw.SetFillColor(115, 115, 115);
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
             Draw.SetLineSize(0);
             Draw.SetFillColor(158, 158, 158);
             Draw.Rectangle(340, 70, 90, 10);
             Draw.Triangle(340, 80, 340, 90, 330, 90);
             Draw.Square(330, 90, 10);
             Draw.Triangle(340, 100, 340, 110, 330, 100);
             Draw.Rectangle(340, 80, 10, 40);
             Draw.Triangle(350, 80, 360, 80, 350, 90);
             Draw.Triangle(340, 120, 350, 120, 350, 130);
             Draw.Rectangle(350, 110, 10, 30);
             Draw.Triangle(350, 100, 360, 110, 350, 110);
             Draw.Rectangle(360, 110, 10, 50);
             Draw.Triangle(360, 140, 360, 150, 350, 140);
             Draw.Triangle(360, 160, 370, 160, 370, 170);
             Draw.Rectangle(380, 80, 20, 30);
             Draw.Triangle(400, 80, 410, 80, 400, 90);
             Draw.Triangle(400, 100, 410, 110, 400, 110);
             Draw.Rectangle(370, 110, 60, 10);
             Draw.Square(400, 120, 20);
             Draw.Triangle(430, 100, 430, 110, 420, 110);
             Draw.Triangle(420, 120, 430, 120, 420, 130);
             Draw.Triangle(410, 140, 420, 140, 410, 150);
             Draw.Rectangle(370, 140, 40, 10);
             Draw.Rectangle(370, 160, 30, 10);
             Draw.Triangle(400, 160, 410, 160, 400, 170);
             Draw.Square(400, 150, 10);
             Draw.Quad(430, 80, 440, 90, 440, 100, 430, 110);
             Draw.Triangle(420, 80, 430, 80, 430, 90);
             Draw.Triangle(370, 80, 380, 80, 380, 90);
             Draw.Triangle(380, 100, 380, 110, 370, 110);
             Draw.Triangle(370, 130, 380, 140, 370, 140);
             Draw.Triangle(400, 130, 400, 140, 390, 140);

             //Draw Nose
             Draw.SetLineSize(0);
             Draw.SetFillColor(Color.Black);
             Draw.Rectangle(370, 120, 30, 10);
             Draw.Quad(370, 130, 400, 130, 390, 140, 380, 140);

             //Draw Eyes
             Draw.SetLineSize(0);
             Draw.SetFillColor(232, 228, 0);
             Draw.Triangle(360, 80, 360, 90, 350, 90);
             Draw.Triangle(370, 80, 380, 90, 370, 90);
             Draw.Triangle(370, 100, 380, 100, 370, 110);
             Draw.Triangle(350, 100, 360, 100, 360, 110);
             Draw.Square(360, 80, 10);
             Draw.Square(370, 90, 10);
             Draw.Square(360, 100, 10);
             Draw.Square(350, 90, 10);
             Draw.Triangle(410, 80, 410, 90, 400, 90);
             Draw.Triangle(420, 80, 430, 90, 420, 90);
             Draw.Triangle(420, 100, 430, 100, 420, 110);
             Draw.Triangle(400, 100, 410, 100, 410, 110);
             Draw.Square(410, 80, 10);
             Draw.Square(420, 90, 10);
             Draw.Square(410, 100, 10);
             Draw.Square(400, 90, 10);

             //Draw Pupils
             Draw.SetLineSize(0);
             Draw.SetFillColor(Color.Black);
             Draw.Square(360, 90, 10);
             Draw.Square(410, 90, 10);

             //Draw Mouth
             Draw.SetLineSize(0);
             Draw.SetFillColor(Color.Black);
             Draw.Square(380, 150, 10);
             Draw.SetFillColor(Color.Black);
             Draw.Square(370, 150, 10);
             Draw.Square(390, 150, 10);
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.W) == true)
            {
                //If it is, then:
                y1 -= 100 * Time.DeltaTime;
                y2 -= 100 * Time.DeltaTime;
                y3 -= 100 * Time.DeltaTime;
                y4 -= 100 * Time.DeltaTime;
                y5 -= 100 * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.A) == true)
            {
                //If it is, then:
                x1 -= 100 * Time.DeltaTime;
                x2 -= 100 * Time.DeltaTime;
                x3 -= 100 * Time.DeltaTime;
                x4 -= 100 * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.S) == true)
            {
              //If it is, then:
              y1 += 100 * Time.DeltaTime;
              y2 += 100 * Time.DeltaTime;
              y3 += 100 * Time.DeltaTime;
              y4 += 100 * Time.DeltaTime;
              y5 += 100 * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D) == true)
            {
                //If it is, then:
                x1 += 100 * Time.DeltaTime;
                x2 += 100 * Time.DeltaTime;
                x3 += 100 * Time.DeltaTime;
                x4 += 100 * Time.DeltaTime;
            }

            //Make player character
            Draw.SetFillColor(171, 3, 3);

            //Make Head
            Draw.SetLineSize(0);
            Draw.Rectangle(x1, y1, 50, 40);
            Draw.SetLineSize(1);
            Draw.Quad(x1, y1, x2, y3, x3, y3, x4, y1);
            Draw.Quad(x1, y4, x4, y4, x3, y5, x2, y5);

            //Make Player Body
            Draw.Rectangle(x2, y2, 30, 40);
        }
}
