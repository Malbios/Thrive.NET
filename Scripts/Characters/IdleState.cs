namespace Thrive.Characters;

public partial class IdleState : CharacterState
{
	protected override void EnterState()
	{
	}
	
	protected override void ExitState()
	{
	}
	
	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		Character.Move();
	}
}
