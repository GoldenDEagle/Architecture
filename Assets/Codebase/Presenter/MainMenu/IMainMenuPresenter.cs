using Assets.Codebase.Presenter.Base;
using UniRx;

namespace Assets.Codebase.Presenter.MainMenu
{
    public interface IMainMenuPresenter : IPresenter
    {
        public ReactiveProperty<string> StartButtonText { get; }

        public void OnStartButtonClicked();
    }
}
