using Assets.Codebase.Presenter.MainMenu;
using Assets.Codebase.Utils.Extensions;
using Assets.Codebase.Views.Base;
using TMPro;
using UniRx;
using UnityEngine.UI;

namespace Assets.Codebase.Views.MainMenu
{
    // Example view
    public class MainMenuView : BaseView
    {
        private IMainMenuPresenter _presenter;

        private TMP_Text _startStopText;
        private Button _startButton;

        public void Init(IMainMenuPresenter presenter)
        {
            _presenter = presenter;
        }

        private void OnEnable()
        {
            // Handle user interactions
            _startButton.OnClickAsObservable().Subscribe( _ => _presenter.OnStartButtonClicked()).AddTo(CompositeDisposable);

            // Handle presenter notificatons
            _presenter.StartButtonTextKey.SubscribeToTMPText(_startStopText).AddTo(CompositeDisposable);
        }

        private void OnDisable()
        {
            CompositeDisposable.Dispose();
        }
    }
}
