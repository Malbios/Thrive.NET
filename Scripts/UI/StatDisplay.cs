using Godot;

namespace Thrive.UI;

[Tool]
public partial class StatDisplay : HBoxContainer
{
	private string _statName;

	[Export] private string StatName
	{
		get => _statName;
		set
		{
			_statName = value;

			if (_nameLabel != null)
			{
				_nameLabel.Text = $"{_statName}:";
			}
		}
	}
	
	private string _statValue;
	
	[Export] public string StatValue
	{
		get => _statValue;
		set
		{
			_statValue = value;

			if (!IsInsideTree())
				return;
			
			_valueLabel.Text = _statValue;
		}
	}

	[Export] private Label _nameLabel;
	[Export] private Label _valueLabel;
}
