// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEngine;

namespace Helyn.DesignSystem
{
	public class MenuItemPrefabs : ScriptableObject
	{
		[Header("Backgrounds")]
		[SerializeField]
		private GameObject backgroundPrefab;

		public GameObject BackgroundPrefab => backgroundPrefab;

		[Header("Texts")]
		[SerializeField]
		private GameObject textPrefab;

		public GameObject TextPrefab => textPrefab;

		[Header("Buttons")]
		[SerializeField]
		private GameObject buttonPrefab;

		public GameObject ButtonPrefab => buttonPrefab;

		[SerializeField]
		private GameObject toggleButtonPrefab;

		public GameObject ToggleButtonPrefab => toggleButtonPrefab;

		[Header("Input fields")]
		[SerializeField]
		private GameObject inputFieldPrefab;

		public GameObject InputFieldPrefab => inputFieldPrefab;

		[Header("Sliders")]
		[SerializeField]
		private GameObject sliderPrefab;

		public GameObject SliderPrefab => sliderPrefab;

		[Header("Dropdown")]
		[SerializeField]
		private GameObject dropdownPrefab;

		public GameObject DropdownPrefab => dropdownPrefab;
	}
}