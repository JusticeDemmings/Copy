using System;
using System.Numerics;

namespace MohawkGame2D;

public class Tree
{
	Vector2 position

	//Triangle Variables


	public void Setup()
	{
		position = Random.Vector2(Window.Size);
	}

	public void Update()
	{
		Draw.LineSize(0);
		Draw.SetFillColor(Color.White);
		Draw.Triangle(position);
	}
}
