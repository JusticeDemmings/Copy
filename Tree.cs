using System;
using System.Numerics;

namespace MohawkGame2D;

public class Tree
{
	Vector2 position;

	//Triangle Variables


	public void Setup()
	{
		position = Random.Vector2(Window.Size);
	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.White);
		Draw.Triangle(200, 300, 250, 300, 200, 350);
	}
}
