using Assets.Codebase.Presenter.MainMenu;
using Assets.Codebase.Presenters.Base;
using Assets.Codebase.Views.Base;
using UniRx;

namespace Assets.Codebase.Presenters.MainMenu
{
    // Example presenter
    public class MainMenuPresenter : BasePresenter, IMainMenuPresenter
    {
        private const string StartText = "Start";
        private const string StopText = "Stop";

        public ReactiveProperty<string> StartButtonText { get; private set; }

        public MainMenuPresenter()
        {
            // Corresponding view id
            ViewId = ViewId.MainMenu;

            // Reactive property for each window element
            StartButtonText = new ReactiveProperty<string>(StartText);
        }


        public void OnStartButtonClicked()
        {
            if (StartButtonText.Value == StartText)
            {
                StartButtonText.Value = StopText;
            }
            else
            {
                StartButtonText.Value = StartText;
            }
        }
    }
}
