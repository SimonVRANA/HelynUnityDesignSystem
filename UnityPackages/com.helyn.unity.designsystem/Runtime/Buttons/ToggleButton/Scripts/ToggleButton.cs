// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEngine;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	public class ToggleButton : ButtonBase
	{
		[SerializeField]
		private Image toggleImage;

		[SerializeField]
		private Sprite untoggledSprite;

		[SerializeField]
		private Sprite toggledSprite;

		private bool isToggled = false;
		public bool IsToggled
		{
			get => isToggled;
			set
			{
				isToggled = value;
				toggleImage.sprite = isToggled ? toggledSprite
											   : untoggledSprite;
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();

			onClick.AddListener(SwitchToggled);
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			onClick.RemoveListener(SwitchToggled);
		}

		private void SwitchToggled()
		{
			IsToggled = !IsToggled;
		}
	}
}
