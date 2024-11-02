// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEngine;
using UnityEngine.Events;
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

		[SerializeField]
		private UnityEvent onToggle;

		private bool isToggled = false;
		public bool IsToggled
		{
			get => isToggled;
			set
			{
				if (value != isToggled)
				{
					isToggled = value;
					toggleImage.sprite = isToggled ? toggledSprite
												   : untoggledSprite;
					onToggle?.Invoke();
				}
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
