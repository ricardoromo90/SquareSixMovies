using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Common;

namespace SquareSixMovies.ViewModels
{
	public class BasePageViewModel : ObservableObject, IInitialize
	{
		public readonly INavigationService NavigationService;

		public BasePageViewModel(INavigationService navigationService)
		{
			NavigationService = navigationService;
		}

		public virtual void Initialize(INavigationParameters parameters)
		{

		}
	}
}

