using System;
using Thrive.Common;
using Godot;

namespace Thrive.Resources;

[GlobalClass]
public partial class StatResource : Resource
{
	private float _value;

	public event Action OnZero;
	
	[Export] public Stat Type { get; private set; }

	[Export] public float MaxValue { get; private set; }
	
	public float Value
	{
		get => _value;
		set
		{
			_value = Mathf.Clamp(value, 0, MaxValue);
			
			if (_value == 0)
			{
				OnZero?.Invoke();
			}
		}
	}
}
