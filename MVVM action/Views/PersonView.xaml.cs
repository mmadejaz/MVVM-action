using MVVM_action.ViewModels;

namespace MVVM_action.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
        BindingContext = new PersonViewModel();
    }
}