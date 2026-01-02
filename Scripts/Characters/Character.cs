using Godot;

namespace Thrive.Characters;

public abstract partial class Character : CharacterBody3D
{
	public Vector2 Direction { get; set; } = Vector2.Zero;
	
	[Export(PropertyHint.Range, "0,20,0.1")] public float MoveSpeed { get; private set; } = 10f; 
	
	[Export] public StateMachine StateMachine { get; private set; }

	public void Move()
	{
		Velocity =  new(Direction.X, 0, Direction.Y);
		Velocity *= MoveSpeed;
		
		MoveAndSlide();
	}
}
