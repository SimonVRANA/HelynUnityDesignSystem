// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEditor;
using UnityEditor.UI;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	[CustomEditor(typeof(SliderBase))]
	public class SliderBaseCustomEditor : SliderEditor
	{
		private SerializedProperty bordersImage;
		private SerializedProperty bordersColor;
		private SerializedProperty diasabledBordersColor;

		private SerializedProperty backgroundImage;
		private SerializedProperty backgroundColor;
		private SerializedProperty diasabledBackgroundColor;

		private SerializedProperty fillImage;
		private SerializedProperty fillColor;
		private SerializedProperty diasabledFillColor;

		protected override void OnEnable()
		{
			base.OnEnable();

			bordersImage = serializedObject.FindProperty("bordersImage");
			bordersColor = serializedObject.FindProperty("bordersColor");
			diasabledBordersColor = serializedObject.FindProperty("diasabledBordersColor");

			backgroundImage = serializedObject.FindProperty("backgroundImage");
			backgroundColor = serializedObject.FindProperty("backgroundColor");
			diasabledBackgroundColor = serializedObject.FindProperty("diasabledBackgroundColor");

			fillImage = serializedObject.FindProperty("fillImage");
			fillColor = serializedObject.FindProperty("fillColor");
			diasabledFillColor = serializedObject.FindProperty("diasabledFillColor");
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			EditorGUILayout.LabelField("Button base", EditorStyles.boldLabel);

			EditorGUILayout.ObjectField(bordersImage, typeof(Image));
			bordersColor.colorValue = EditorGUILayout.ColorField("Borders Color", bordersColor.colorValue);
			diasabledBordersColor.colorValue = EditorGUILayout.ColorField("Diasabled Borders Color", diasabledBordersColor.colorValue);

			EditorGUILayout.Space();

			EditorGUILayout.ObjectField(backgroundImage, typeof(Image));
			backgroundColor.colorValue = EditorGUILayout.ColorField("Background Color", backgroundColor.colorValue);
			diasabledBackgroundColor.colorValue = EditorGUILayout.ColorField("Diasabled Background Color", diasabledBackgroundColor.colorValue);

			EditorGUILayout.Space();

			EditorGUILayout.ObjectField(fillImage, typeof(Image));
			fillColor.colorValue = EditorGUILayout.ColorField("Fill Color", fillColor.colorValue);
			diasabledFillColor.colorValue = EditorGUILayout.ColorField("Diasabled Fill Color", diasabledFillColor.colorValue);

			serializedObject.ApplyModifiedProperties();
		}
	}
}
