using groceryApp.Models;
using groceryApp.ViewModels;

namespace groceryApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel homePageViewModel)
	{
		InitializeComponent();
		this.BindingContext = homePageViewModel;
	}
}
