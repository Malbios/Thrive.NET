using System.Linq;
using Godot;
using Thrive.Common;

namespace Thrive.Characters;

public partial class StateMachine : Node
{
	[Export]
	public CharacterState CurrentState;

	[Export]
	private CharacterState[] _states;

	public override void _Ready()
	{
		base._Ready();
		
		CurrentState.Notification(Constants.NOTIFICATION_STATE_ENABLE);
	}

	public bool IsInState<T>() where T : CharacterState
	{
		return CurrentState is T;
	}

	public void SwitchState<T>() where T : CharacterState
	{
		if (CurrentState is T) { return; }
		
		var newState = _states.FirstOrDefault(x => x is T);
		if (newState == null) { return; }

		CurrentState.Notification(Constants.NOTIFICATION_STATE_DISABLE);
		CurrentState = newState;
		CurrentState.Notification(Constants.NOTIFICATION_STATE_ENABLE);
	}
}
