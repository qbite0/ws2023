using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using GeneralEmployeeTerminal.Models;
using GeneralEmployeeTerminal.ViewModels;

namespace GeneralEmployeeTerminal.Views {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            datagrid1.IsReadOnly = true;
            datagrid1.DoubleTapped += Handler;
        }

        private void Handler(object? sender, RoutedEventArgs e) {
            var infoWin = new TicketInfoWindow();
            infoWin.DataContext = new TicketInfoViewModel((Ticket)datagrid1.SelectedItem);
            infoWin.Show();
        }
    }
}