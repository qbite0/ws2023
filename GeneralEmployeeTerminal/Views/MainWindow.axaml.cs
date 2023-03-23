using Avalonia.Controls;
using Avalonia.Interactivity;
using GeneralEmployeeTerminal.Models;
using MessageBox.Avalonia;
using System;

namespace GeneralEmployeeTerminal.Views {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            datagrid1.IsReadOnly = true;
            datagrid1.DoubleTapped += Handler;
        }

        private void Handler(object? sender, RoutedEventArgs e)
        {
            Ticket ticket = (Ticket)datagrid1.SelectedItem;
            var infoWin = new TicketInfoWindow();
            infoWin.DataContext = ticket;
            infoWin.Show();
        }
    }
}