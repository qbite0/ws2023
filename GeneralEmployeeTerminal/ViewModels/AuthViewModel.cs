using System;
using ReactiveUI;
using MessageBox.Avalonia;
using GeneralEmployeeTerminal.Views;
using GeneralEmployeeTerminal.Models;

namespace GeneralEmployeeTerminal.ViewModels
{
    public class AuthViewModel : ViewModelBase
    {
        private string _searchTerm;
        public string SearchTerm
        {
            get => _searchTerm;
            set => this.RaiseAndSetIfChanged(ref _searchTerm, value);
        }

        public async void ButtonClickedAsync()
        {
            var result = await ApiClient.IsEmployeeExistsAsync(Guid.Parse(SearchTerm));
            if (result == true)
            {
                var model = new MainWindow();
                model.Show();
            }
            else
            {
                _ = MessageBoxManager.GetMessageBoxStandardWindow(
                    "Ошибка",
                    $"Произошла ошибка"
                    ).Show();
            }
        }
    }
}