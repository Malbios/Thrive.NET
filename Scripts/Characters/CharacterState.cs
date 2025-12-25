using Godot;
using Thrive.Common;

namespace Thrive.Characters;

public abstract partial class CharacterState : Node
{
	protected Character Character;
	
	protected abstract void EnterState();
	protected abstract void ExitState();

	public override void _Ready()
	{
		base._Ready();
		
		Character = GetOwner<Character>();
		
		SetProcessing(false);
	}

	public override void _Notification(int what)
	{
		base._Notification(what);

		switch (what)
		{
			case Constants.NOTIFICATION_STATE_ENABLE:
				SetEnabled(true);
				break;
			
			case Constants.NOTIFICATION_STATE_DISABLE:
				SetEnabled(false);
				break;
		}
	}

	private void SetProcessing(bool enabled)
	{
		SetPhysicsProcess(enabled);
		SetProcessInput(enabled);
	}
	
	private void SetEnabled(bool enabled)
	{
		if (!enabled)
		{
			ExitState();
		}
		
		SetProcessing(enabled);

		if (enabled)
		{
			EnterState();
		}
	}
}
