using Godot;
using Thrive.Common;

namespace Thrive.UI;

public partial class NewGame : Button
{
	public override void _Ready()
	{
		base._Ready();

		Pressed += () =>
		{
			Utils.ChangeScene(GetTree(), "res://Scenes/Levels/node-battle.tscn");
		};
	}
}
