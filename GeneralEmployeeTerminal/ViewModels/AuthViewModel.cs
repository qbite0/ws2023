using System.Net.Http;
using System.Threading.Tasks;
using System;
using Avalonia.Controls;
using ReactiveUI;

namespace GeneralEmployeeTerminal.ViewModels {
    public class AuthViewModel : ViewModelBase {
        const string API_URL = "https://localhost:7287";

        private async Task<bool> IsEmployeeExistsAsync(Guid id) {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync($"{API_URL}/api/Employee/{id}");
                return response.IsSuccessStatusCode;
            }
        }

        private string _searchTerm;
        public string SearchTerm {
            get => _searchTerm;
            set => this.RaiseAndSetIfChanged(ref _searchTerm, value);
        }

        public async void ButtonClickedAsync() {
            var result = await IsEmployeeExistsAsync(Guid.Parse(SearchTerm));
            if (result == true) {
                throw new Exception("Успешно");
            } else {
                throw new Exception("Произошла ошибка");
            }
        }
    }
}