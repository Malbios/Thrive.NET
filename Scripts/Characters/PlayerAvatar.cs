using Godot;
using Thrive.Common;
using Thrive.Resources;

namespace Thrive.Characters;

public partial class PlayerAvatar : Character
{
	[Export] public StatResource Health = new();

	public override void _Ready()
	{
		base._Ready();

		Health.Value = Health.MaxValue;
	}

	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		if (Input.IsPhysicalKeyPressed(Key.Escape))
		{
			GetTree().Quit();
		}

		Direction = Input.GetVector(Constants.INPUT_MOVE_LEFT, Constants.INPUT_MOVE_RIGHT, Constants.INPUT_MOVE_FORWARD, Constants.INPUT_MOVE_BACKWARD);
	}
}
