using System.Collections.Generic;
using System.Reactive.Concurrency;
using GeneralEmployeeTerminal.Models;
using ReactiveUI;

namespace SecurityOfficerTerminal.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        private Ticket[] _people;
        public Ticket[] People {
            get => _people;
            set => this.RaiseAndSetIfChanged(ref _people, value);
        }

        public MainWindowViewModel() {
            RxApp.MainThreadScheduler.Schedule(LoadTickets);
        }

        private async void LoadTickets() {
            People = await ApiClient.GetApprovedTickets();
        }
    }
}