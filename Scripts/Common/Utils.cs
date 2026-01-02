using Godot;

namespace Thrive.Common;

public static class Utils
{
	public static void ChangeScene(SceneTree tree, string newScenePath)
	{
		var newScene = ResourceLoader.Load<PackedScene>(newScenePath).Instantiate();
		var currentScene = tree.GetCurrentScene();
		tree.GetRoot().AddChild(newScene);
		tree.GetRoot().RemoveChild(currentScene);
		tree.SetCurrentScene(newScene);
		currentScene.QueueFree();
	}
}
