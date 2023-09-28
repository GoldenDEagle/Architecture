using Assets.Codebase.Presenter.Base;
using Assets.Codebase.Presenter.MainMenu;
using Assets.Codebase.Presenters.Base;
using Assets.Codebase.Utils.Extensions;
using Assets.Codebase.Views.Base;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Codebase.Views.MainMenu
{
    // Example view
    public class MainMenuView : BaseView
    {
        private IMainMenuPresenter _presenter;

        [SerializeField] private TMP_Text _startStopText;
        [SerializeField] private Button _startButton;

        public override void Init(IPresenter presenter)
        {
            _presenter = presenter as IMainMenuPresenter;

            base.Init(_presenter);
        }

        protected override void SubscribeToUserInput()
        {
            // Handle all button, tooggles, input fields, etc.
            _startButton.OnClickAsObservable().Subscribe(_ => _presenter.OnStartButtonClicked()).AddTo(CompositeDisposable);
        }

        protected override void SubscribeToPresenterEvents()
        {
            // Handle presenter events
            _presenter.StartButtonText.SubscribeToTMPText(_startStopText).AddTo(CompositeDisposable);
        }
    }
}
