using System.Collections.ObjectModel;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using Avalonia.Controls;
using AvaloniaEdit.Utils;
using GeneralEmployeeTerminal.Models;
using GeneralEmployeeTerminal.Views;
using ReactiveUI;

namespace GeneralEmployeeTerminal.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        public ObservableCollection<Ticket> Tickets { get; }
        //public Ticket CurrentTicket { get; set; }

        public MainWindowViewModel() {
            Tickets = new ObservableCollection<Ticket>();
            RxApp.MainThreadScheduler.Schedule(LoadTickets);
        }

        private async void LoadTickets() {
            Tickets.AddRange(await ApiClient.GetTickets());
        }
    }
}