// This code has been made by Simon VRANA.
// Please ask by email (simon.vrana.pro@gmail.com) before reusing for commercial purpose.

using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Helyn.DesignSystem
{
	public class InputFieldBase : TMP_InputField
	{
		[SerializeField]
		private Image bordersImage;

		[SerializeField]
		private Color bordersColor;

		[SerializeField]
		private Color diasabledBordersColor;

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
			base.DoStateTransition(state, instant);
			if (bordersImage != null)
			{
				bordersImage.color = interactable ? bordersColor
												  : diasabledBordersColor;
			}
		}
	}
}
