

using Godot;

namespace Thrive.Extensions;

public static class Vector3Extensions
{
	public static Vector2 ToVector2_X_Z(this Vector3 v)
	{
		return new Vector2(v.X, v.Z);
	}
}
