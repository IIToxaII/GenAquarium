using Godot;
using System;

public partial class DublicateNode : Node2D
{
	[Export]
	private Node2D node;
	private int count = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (count < 3000) {
		var newNode = node.Duplicate();
		((Node2D)newNode).GlobalPosition = new Vector2(0,0);
		this.AddChild(newNode);
		count++;
		}
	}
}
