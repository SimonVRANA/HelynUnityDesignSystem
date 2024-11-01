// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	[CustomEditor(typeof(ToggleButton))]
	public class ToggleButtonCustomEditor : ButtonBaseCustomEditor
	{

		private SerializedProperty toggleImage;
		private SerializedProperty untoggledSprite;
		private SerializedProperty toggledSprite;

		protected override void OnEnable()
		{
			base.OnEnable();

			toggleImage = serializedObject.FindProperty("toggleImage");
			untoggledSprite = serializedObject.FindProperty("untoggledSprite");
			toggledSprite = serializedObject.FindProperty("toggledSprite");
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.LabelField("Toggle", EditorStyles.boldLabel);

			EditorGUILayout.ObjectField(toggleImage, typeof(Image));
			EditorGUILayout.ObjectField(untoggledSprite, typeof(Sprite));
			EditorGUILayout.ObjectField(toggledSprite, typeof(Sprite));

			serializedObject.ApplyModifiedProperties();
		}
	}
}