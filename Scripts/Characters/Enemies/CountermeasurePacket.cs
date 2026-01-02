using Godot;

namespace Thrive.Characters.Enemies;

public partial class CountermeasurePacket : Character
{
	[Export] private Area3D _hitbox;
	[Export] private float _damage;
	[Export] private Node3D _target;

	public override void _Ready()
	{
		base._Ready();

		_hitbox.BodyEntered += OnBodyHit();
		
		if (StateMachine.CurrentState is ChaseState chaseState)
		{
			chaseState.Target = _target;
		}
	}

	private Area3D.BodyEnteredEventHandler OnBodyHit()
	{
		return body =>
		{
			if (body is not PlayerAvatar player)
				return;
			
			player.Health.Value -= _damage;
			QueueFree();
		};
	}
}
