using Godot;

namespace Thrive.UI;

public partial class Quit : Button
{
	public override void _Ready()
	{
		base._Ready();
		
		Pressed += () => GetTree().Quit();
	}
}
