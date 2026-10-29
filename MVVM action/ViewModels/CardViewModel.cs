using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM_action.Models;

namespace MVVM_action.ViewModels
{
    internal partial class CardViewModel: ObservableObject
    {
        [ObservableProperty]
        private string color;
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private int value;
        [ObservableProperty]
        private string image = "dotnet_bot.png";

        [RelayCommand]
        private void ShowDA()
        {
            Image = "da.png";
        }
    }
}
