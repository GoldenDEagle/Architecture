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

        // Reactive property for each changable window element
        public ReactiveProperty<string> StartButtonText { get; private set; }
        public ReactiveProperty<string> GoldAmountText {  get; private set; } 

        public MainMenuPresenter()
        {
            // Corresponding view id
            ViewId = ViewId.MainMenu;

            // Init all properties
            StartButtonText = new ReactiveProperty<string>(StartText);
            GoldAmountText = new ReactiveProperty<string>(0.ToString());
        }

        protected override void SubscribeToModelChanges()
        {
            // Subscribe to each model parameter of interest
            ProgressModel.ReactiveProgress.Gold.Subscribe(OnGoldAmountChanged).AddTo(CompositeDisposable);
        }

        private void OnGoldAmountChanged(int newGoldAmount)
        {
            GoldAmountText.Value = newGoldAmount.ToString();
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

            ProgressModel.ReactiveProgress.Gold.Value++;
        }
    }
}
