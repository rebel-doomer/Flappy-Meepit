using Godot;
using System;

public partial class KillZone : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// base._Ready();
		BodyEntered += HandlePlayerOverlap;
	}

	private void HandlePlayerOverlap(Node2D body)
	{
		if (body is Player player)
		{ // the game restarts the level in the middle of a physics step. thus, added CallDeferred() to tell Godot to do the restart a moment later, once that step is done.
			GetTree().CallDeferred(SceneTree.MethodName.ReloadCurrentScene);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
