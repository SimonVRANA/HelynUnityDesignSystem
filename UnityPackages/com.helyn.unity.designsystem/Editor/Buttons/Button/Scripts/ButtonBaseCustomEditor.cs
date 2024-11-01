// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEditor;
using UnityEditor.UI;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	[CustomEditor(typeof(ButtonBase))]
	public class ButtonBaseCustomEditor : ButtonEditor
	{
		private SerializedProperty bordersImage;
		private SerializedProperty bordersColor;
		private SerializedProperty diasabledBordersColor;

		protected override void OnEnable()
		{
			base.OnEnable();

			bordersImage = serializedObject.FindProperty("bordersImage");
			bordersColor = serializedObject.FindProperty("bordersColor");
			diasabledBordersColor = serializedObject.FindProperty("diasabledBordersColor");
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.LabelField("Button base", EditorStyles.boldLabel);

			EditorGUILayout.ObjectField(bordersImage, typeof(Image));
			bordersColor.colorValue = EditorGUILayout.ColorField("Borders Color", bordersColor.colorValue);
			diasabledBordersColor.colorValue = EditorGUILayout.ColorField("Diasabled Borders Color", diasabledBordersColor.colorValue);

			serializedObject.ApplyModifiedProperties();
		}
	}
}