// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEditor;
using UnityEngine;

namespace Helyn.DesignSystem
{
	public class MenuItems : MonoBehaviour
	{
		private const string menuName = "GameObject/UI/Helyn/";
		private const string menuItemPrefabsScriptableObjectGUID = "125f3d68bbef9334ba2c9c40bea77f08";

		private static MenuItemPrefabs GetMenuItemPrefabs()
		{
			return (MenuItemPrefabs)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(menuItemPrefabsScriptableObjectGUID), typeof(MenuItemPrefabs));
		}
		private static void SafeInstantiate(GameObject prefab)
		{

			Object instance = PrefabUtility.InstantiatePrefab(prefab, Selection.activeTransform);

			Undo.RegisterCreatedObjectUndo(instance, $"Create {instance.name}");
			Selection.activeObject = instance;
		}

		#region Backgrounds
		[MenuItem(menuName + "Background")]
		public static void Background()
		{
			SafeInstantiate(GetMenuItemPrefabs().BackgroundPrefab);
		}
		#endregion

		#region Texts
		[MenuItem(menuName + "Texts")]
		public static void Text()
		{
			SafeInstantiate(GetMenuItemPrefabs().TextPrefab);
		}
		#endregion

		#region Buttons
		private const string buttonsMenuName = "GameObject/UI/Helyn/Buttons/";

		[MenuItem(buttonsMenuName + "Button")]
		public static void Button()
		{
			SafeInstantiate(GetMenuItemPrefabs().ButtonPrefab);
		}

		[MenuItem(buttonsMenuName + "Toggle button")]
		public static void ToggleButton()
		{
			SafeInstantiate(GetMenuItemPrefabs().ToggleButtonPrefab);
		}
		#endregion


		#region InputField
		[MenuItem(menuName + "InputField")]
		public static void InputField()
		{
			SafeInstantiate(GetMenuItemPrefabs().InputFieldPrefab);
		}
		#endregion


		#region Slider
		[MenuItem(menuName + "Slider")]
		public static void Slider()
		{
			SafeInstantiate(GetMenuItemPrefabs().SliderPrefab);
		}
		#endregion
	}
}
