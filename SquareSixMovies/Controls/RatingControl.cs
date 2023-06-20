using System;
using SquareSixMovies.Utils.Enums;

namespace SquareSixMovies.Controls
{
	public class RatingControl : HorizontalStackLayout
	{
		public static readonly BindableProperty CurrentValueProperty = BindableProperty.Create(
			nameof(CurrentValue),
			typeof(double),
			typeof(RatingControl),
			defaultValue: 0d,
			propertyChanged: OnRefreshControl);

		public static readonly BindableProperty AmountProperty = BindableProperty.Create(
			nameof(Amount),
			typeof(int),
			typeof(RatingControl),
			defaultValue: 10,
			propertyChanged: OnRefreshControl);

		public double CurrentValue {
			get => (double)GetValue(CurrentValueProperty);
			set => SetValue(CurrentValueProperty, value);
		}

		public int Amount {
			get => (int)GetValue(AmountProperty);
			set => SetValue(AmountProperty, value);
		}

		private static void OnRefreshControl(BindableObject bindable, object oldValue, object newValue)
		{
			if (bindable is RatingControl ratingControl)
				ratingControl.UpdateLayout();
		}


		public RatingControl()
		{
			Spacing = 2;
		}

		private void UpdateLayout()
		{
			Children.Clear();
			for (int i = 0; i < Amount; i++) {
				if (CurrentValue <= i) {
					Add(CreateStarLabel(StarState.Full));
				} else {
					Add(CreateStarLabel(StarState.Empty));
				}
			}
		}

		private Image CreateStarLabel(StarState state)
		{
			return new Image {
				HeightRequest = 30,
				WidthRequest = 30,
				Source = state switch {
					StarState.Empty => "ic_star_empty",
					_ => "ic_star_filled",
				}
			};
		}
	}
}