// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

#if UNITY_EDITOR

using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Helyn.DesignSystem
{
	/// <summary>
	/// Little utility for opening a "Game" view in fullscreen. Will be opened on whatever Unity thinks is the "main"
	/// monitor at the moment. The hotkey will toggle the window; however, if for some reason this breaks, fullscreen
	/// windows can be closed via Alt+F4 as long as the editor is not in play mode.
	/// </summary>
	/// <remarks>
	/// Confirmed to work in Unity 2019 and 2020. May work in earlier and later versions. No promises.
	/// </remarks>
	public static class FullscreenPlayMode
	{
		static readonly Type gameViewType = Type.GetType("UnityEditor.GameView,UnityEditor");
		static readonly PropertyInfo showToolbarProperty = gameViewType.GetProperty("showToolbar", BindingFlags.Instance | BindingFlags.NonPublic);

		static EditorWindow instance;

		[MenuItem("Window/General/Game (Fullscreen) %#&2", priority = 2)]
		public static void Toggle()
		{
			if (gameViewType == null)
			{
				Debug.LogError("GameView type not found.");
				return;
			}

			if (showToolbarProperty == null)
			{
				Debug.LogWarning("GameView.showToolbar property not found.");
			}

			if (instance != null)
			{
				instance.Close();
				instance = null;
			}
			else
			{
				instance = (EditorWindow)ScriptableObject.CreateInstance(gameViewType);

				showToolbarProperty?.SetValue(instance, false);

				Vector2 desktopResolution = new(Screen.currentResolution.width, Screen.currentResolution.height);
				Rect fullscreenRect = new(Vector2.zero, desktopResolution);
				instance.ShowPopup();
				instance.position = fullscreenRect;
				instance.Focus();
			}
		}
	}
}
#endif