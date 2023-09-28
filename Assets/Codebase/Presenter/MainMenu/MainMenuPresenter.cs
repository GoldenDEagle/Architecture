using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;
using Assets.Codebase.Presenter.MainMenu;
using Assets.Codebase.Presenters.Base;
using UniRx;

namespace Assets.Codebase.Presenters.MainMenu
{
    // Example presenter
    public class MainMenuPresenter : BasePresenter, IMainMenuPresenter
    {
        private const string StartText = "Start";
        private const string StopText = "Stop";

        public ReactiveProperty<string> StartButtonTextKey { get; private set; }

        public MainMenuPresenter(IProgressModel progressModel, IGameplayModel gameplayModel) : base(progressModel, gameplayModel)
        {
            StartButtonTextKey = new ReactiveProperty<string>(StartText);
        }


        public void OnStartButtonClicked()
        {
            
        }
    }
}
