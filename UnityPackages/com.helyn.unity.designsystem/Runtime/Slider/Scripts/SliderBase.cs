// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using UnityEngine;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	public class SliderBase : Slider
	{
		[SerializeField]
		private Image bordersImage;

		[SerializeField]
		private Color bordersColor;

		[SerializeField]
		private Color diasabledBordersColor;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private Color backgroundColor;

		[SerializeField]
		private Color diasabledBackgroundColor;

		[SerializeField]
		private Image fillImage;

		[SerializeField]
		private Color fillColor;

		[SerializeField]
		private Color diasabledFillColor;

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
			base.DoStateTransition(state, instant);
			if (bordersImage != null)
			{
				bordersImage.color = interactable ? bordersColor
												  : diasabledBordersColor;
				backgroundImage.color = interactable ? backgroundColor
													 : diasabledBackgroundColor;
				fillImage.color = interactable ? fillColor
											   : diasabledFillColor;
			}
		}
	}
}
