using Godot;
using Thrive.Common;

namespace Thrive.Characters;

public partial class TestCharacter : Character
{
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
