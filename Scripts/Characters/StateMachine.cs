using System.Linq;
using Godot;
using Thrive.Common;

namespace Thrive.Characters;

public partial class StateMachine : Node
{
	[Export]
	private CharacterState _currentState;

	[Export]
	private CharacterState[] _states;

	public override void _Ready()
	{
		base._Ready();
		
		_currentState.Notification(Constants.NOTIFICATION_STATE_ENABLE);
	}

	public bool IsInState<T>() where T : CharacterState
	{
		return _currentState is T;
	}

	public void SwitchState<T>() where T : CharacterState
	{
		if (_currentState is T) { return; }
		
		var newState = _states.FirstOrDefault(x => x is T);
		if (newState == null) { return; }

		_currentState.Notification(Constants.NOTIFICATION_STATE_DISABLE);
		_currentState = newState;
		_currentState.Notification(Constants.NOTIFICATION_STATE_ENABLE);
	}
}
