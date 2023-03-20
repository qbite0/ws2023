using System.Collections.ObjectModel;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using AvaloniaEdit.Utils;
using GeneralEmployeeTerminal.Models;
using ReactiveUI;

namespace GeneralEmployeeTerminal.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        public ObservableCollection<Ticket> Tickets { get; }

        public MainWindowViewModel() {
            Tickets = new ObservableCollection<Ticket>();
            RxApp.MainThreadScheduler.Schedule(LoadTickets);
        }

        private async void LoadTickets() {
            Tickets.AddRange(await ApiClient.GetTickets());
        }
    }
}