using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_action.ViewModels
{
    internal partial class PersonViewModel: ObservableObject
    {
        [ObservableProperty]
        private string firstName = "Jan";
        [ObservableProperty]
        private string lastName = "Kot";

        [RelayCommand]
        private void ChangeName()
        {
            FirstName = "Ewa";
            LastName = "Lis";
        }

        [RelayCommand]
        private void ResetName()
        {
            FirstName = "";
            LastName = "";
        }
        [RelayCommand]
        private void RandomName()
        {
            var random = new Random();
            var names = new List<string> {"Adam", "Kacper", "Szymon", "Alicja", "Dorota", "Marcin", "Kuba", "Natalia"};
            var lastNames = new List<string> { "Kowalski", "Kot", "Rak", "Lewandowski", "Błaszczykowski", "Pies" };

            FirstName = names[random.Next(names.Count)];
            LastName = lastNames[random.Next(lastNames.Count)];
        }
    }
}
