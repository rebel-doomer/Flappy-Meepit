using Godot;
using System;

public partial class Player : RigidBody2D
{
	[Export]
	float JumpPower = 100;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
		{
			base._Ready();
		}
	
	// this is the function that will run every frame of the game (FPS)
	public override void _Process(double delta) // public means other objects can see it, override means the parent (rigitbody2) already had made this function but we are adding new code to execute when this function is running, void just executes code but does not deliver any data back, paranthesis parameters is stuff it is supposed to take in when you call the function
	{
		if (Input.IsKeyPressed(Key.Space)) GD.Print("SPACE HELD");
		if (Input.IsActionJustPressed("jump")) GD.Print("JUMP JUST PRESSED");		base._Process(delta); // this tells it to just run the base version (version that rigitbody2d has) if you remove this then it fails to run all the code from rigitbody2d/parent function
		if(Input.IsActionJustPressed("jump"))
		{
			Vector2 Impulse = new Vector2(0, -JumpPower); // x and y axis
			ApplyImpulse(Impulse);
			GD.Print(">>> SPACEBAR PRESSED! APPLYING IMPULSE! <<<");
		}
	}
}

/* {

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
*/
