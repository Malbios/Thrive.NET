using Godot;
using Thrive.Common;

namespace Thrive;

public partial class Camera : Camera3D
{
	[ExportGroup("Defaults")]
	[Export] private float _initialDistance = 10f;
	
	[ExportGroup("Speeds")]
	[Export] private float _rotationSpeed = 0.005f;
	[Export] private float _zoomSpeed = 0.5f;
	
	[ExportGroup("Limits")]
	[Export] private float _minPitch = -80f;
	[Export] private float _maxPitch = -10f;
	[Export] private float _minDistance = 2f;
	[Export] private float _maxDistance = 6f;
	
	[ExportGroup("Nodes")]
	[Export] private Node3D _pivot;
	[Export] private Node3D _orbitingTarget;

	private float _currentDistance;
	private bool _orbiting;
	private float _yaw;
	private float _pitch;

	public override void _Ready()
	{
		_pivot.GlobalPosition = _orbitingTarget.GlobalPosition;
		ZoomCamera(_initialDistance);
		
		var (x, y, _) = _pivot.Rotation;
		_pitch = x;
		_yaw = y;
	}
	
	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		if (@event is InputEventMouseButton { ButtonIndex: MouseButton.Middle } mb)
		{
			_orbiting = mb.Pressed;
		}
		else if (@event.IsAction(Constants.INPUT_ZOOM_IN))
		{
			ZoomCamera(_currentDistance - _zoomSpeed);
		}
		else if (@event.IsAction(Constants.INPUT_ZOOM_OUT))
		{
			ZoomCamera(_currentDistance + _zoomSpeed);
		}
		else if (@event is InputEventMouseMotion motion && _orbiting)
		{
			OrbitCamera(motion.Relative.X, motion.Relative.Y);
		}
	}

	private void ZoomCamera(float distance)
	{
		_currentDistance = Mathf.Clamp(
			distance,
			_minDistance,
			_maxDistance
		);

		var forward = _pivot.GlobalTransform.Basis.Z;
		GlobalPosition = _pivot.GlobalPosition + forward * _currentDistance;
	}

	private void OrbitCamera(float x, float y)
	{
		_yaw   -= x * _rotationSpeed;
		_pitch -= y * _rotationSpeed;
		
		_pitch = Mathf.Clamp(
			_pitch,
			Mathf.DegToRad(_minPitch),
			Mathf.DegToRad(_maxPitch)
		);
		
		_pivot.Rotation = new Vector3(_pitch, _yaw, 0);
	}
}
