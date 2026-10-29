using Godot;
using System;

public partial class Pipes : Area2D
{
	[Export] 
	private float _speed = 200.0f;
	
	private bool _hasScored = false; // Prevents scoring multiple times on the same pipe

	public override void _Ready()
	{
		BodyEntered += HandlePlayerOverlap;
	}

	public override void _Process(double delta)
	{
		Position -= new Vector2(_speed * (float)delta, 0);
		if (Position.X < -170)
		{
			float randPipeHeight = (float)GD.RandRange(-50.0, 150.0);
			Position = new Vector2(442, randPipeHeight);
			_hasScored = false; // Reset when pipe recycles
		}
	}

	private void HandlePlayerOverlap(Node2D body)
	{
		if (body is Player player)
		{
			// If player hits the main pipe, restart the game
			GetTree().CallDeferred(SceneTree.MethodName.ReloadCurrentScene);
		}
	}

	// Bridge method to catch whatever default name Godot generated in the editor
	private void _on_body_entered(Node2D body)
	{
		OnScoreAreaBodyEntered(body);
	}

	// The core scoring logic method
	private void OnScoreAreaBodyEntered(Node2D body)
	{
		if (body is Player && !_hasScored)
		{
			_hasScored = true;

			// Find your unique score label and add 1 directly
			Label scoreLabel = GetTree().CurrentScene.GetNode<Label>("%ScoreLabel");
			if (scoreLabel != null)
			{
				int currentScore = int.Parse(scoreLabel.Text);
				scoreLabel.Text = (currentScore + 1).ToString();
			}
		}
	}
}
