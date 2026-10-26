using System;
using System.Numerics

namespace MohawkGame2D

public class Cupcake
{
	public Cupcake()
	{
		//Make Cupacake
		//Make Cupcake Bottom
		Draw.SetFillColor(2, 222, 222);
		Draw.Rectangle(float x, float y, 30, 20);

		//Make Cupcake
		Draw.SetFillColor(166, 117, 2);
		Draw.Rectangle(float x, float y, 50, 10);
		Draw.SetFillColor(247, 247, 247);
		Draw.Rectangle(float x, float y, 30, 10);

		//Make Cherry
		Draw.SetFillColor(244, 4, 4);
		Draw.Square(10, 10);

	}
}