using Godot;
using Thrive.Extensions;

namespace Thrive.Characters;

public partial class ChaseState : CharacterState
{
	public Node3D Target;
	
	protected override void EnterState()
	{
	}
	
	protected override void ExitState()
	{
	}
	
	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		if (Target != null)
		{
			Character.Direction = Character.GlobalPosition.DirectionTo(Target.GlobalPosition).ToVector2_X_Z();
		}

		Character.Move();
	}
}
