using Godot;
using System;

public partial class Pipes : Area2D
{
	[Export] 
	private float _speed = (float)200.0;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// base._Ready();
		BodyEntered += HandlePlayerOverlap;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position -= new Vector2(_speed * (float)delta, 0);
		if (Position.X < -170)
		{
			// Pick a random Y height between your min and max limits (adjust these numbers to fit your screen)
			float randPipeHeight = (float)GD.RandRange(-50.0, 150.0);
			Position = new Vector2(442, randPipeHeight);
		}
	}
	private void HandlePlayerOverlap(Node2D body)
	{
		if (body is Player player)
		{ // the game restarts the level in the middle of a physics step. thus, added CallDeferred() to tell Godot to do the restart a moment later, once that step is done.
			GetTree().CallDeferred(SceneTree.MethodName.ReloadCurrentScene);
		}
	}
}
