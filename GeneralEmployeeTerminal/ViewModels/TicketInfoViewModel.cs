using System.Collections.ObjectModel;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using AvaloniaEdit.Utils;
using GeneralEmployeeTerminal.Models;
using ReactiveUI;

namespace GeneralEmployeeTerminal.ViewModels {
    public class TicketInfoViewModel : ViewModelBase {
        public Ticket Ticket { get; set; }

        public TicketInfoViewModel(Ticket ticket) {
            Ticket = ticket;
        }

        public async void SaveTicketCommand() {
            var res = await ApiClient.EditTicket(Ticket);
            _ = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("dasd", Ticket.Approved.ToString()).Show();
        }
    }
}