using Godot;
using Thrive.Common;

namespace Thrive;

public partial class Camera : Camera3D
{
	[Export] private float _zoomSpeed = 2f;
	
	[Export] private float _minDistance;
	[Export] private float _maxDistance = 20f;
	
	[Export] private Node3D _pivot;

	private float _currentDistance;

	public override void _Ready()
	{
		_currentDistance = GlobalPosition.DistanceTo(_pivot.GlobalPosition);
	}
	
	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		if (@event.IsAction(Constants.INPUT_ZOOM_IN))
		{
			ZoomCamera(-_zoomSpeed);
		}
		else if (@event.IsAction(Constants.INPUT_ZOOM_OUT))
		{
			ZoomCamera(_zoomSpeed);
		}
	}

	private void ZoomCamera(float amount)
	{
		_currentDistance = Mathf.Clamp(
			_currentDistance + amount,
			_minDistance,
			_maxDistance
		);

		var forward = _pivot.GlobalTransform.Basis.Z;
		GlobalPosition = _pivot.GlobalPosition + forward * _currentDistance;
	}
}
