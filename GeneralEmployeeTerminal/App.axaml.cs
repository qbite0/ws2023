using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GeneralEmployeeTerminal.ViewModels;
using GeneralEmployeeTerminal.Views;

namespace GeneralEmployeeTerminal {
    public partial class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted() {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                desktop.MainWindow = new Auth {
                    DataContext = new AuthViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}