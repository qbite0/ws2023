using ReactiveUI;

namespace GeneralEmployeeTerminal.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        public string Greeting => "Welcome to Avalonia!";

        public MainWindowViewModel() {
            var ShowDialog = new Interaction<MainWindowViewModel, AuthViewModel?>();

            /*BuyMusicCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new MusicStoreViewModel();

                var result = await ShowDialog.Handle(store);
            });*/
        }
    }
}