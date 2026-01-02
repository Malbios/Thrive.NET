using Godot;
using Thrive.Characters;

namespace Thrive.UI;

public partial class PlayerStats : Control
{
	[Export] private PlayerAvatar _player;

	[Export] private StatDisplay _healthDisplay; 

	public override void _Process(double delta)
	{
		base._Process(delta);

		_healthDisplay.StatValue = $"{_player.Health.Value}";
	}
}
