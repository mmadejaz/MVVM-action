using MVVM_action.ViewModels;

namespace MVVM_action.Views;

public partial class CardView : ContentPage
{
	public CardView()
	{
		InitializeComponent();
		BindingContext = new CardViewModel();
	}
}