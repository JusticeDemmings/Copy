using System;
using System.Numerics;

namespace MohawkGame2D

public class Tree
{
	public Tree()
	{
		//Make Tree
		//Make Tree Leaves
		Draw.SetFillColor(19, 94, 4);
		Draw.Triangle(float x, float y, float x, float y, float x, float y);

		//Make Tree Stump
		Draw.SetFillColor(115, 53, 2);
		Draw.Rectangle(float x, float y, 10, 30);

	}
}
