using Godot;

public partial class TestScript : CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// var mat = new Matrix();
		// mat.test();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += new Vector2(30,0) * (float)delta;
		
	}

	public override void _PhysicsProcess(double delta)
	{
	}
}
