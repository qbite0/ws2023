using Avalonia.Controls;

namespace GeneralEmployeeTerminal.Views {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Hide();
            var _auth = new Auth();
            _auth.Show();
        }
    }
}