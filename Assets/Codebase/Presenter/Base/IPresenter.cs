using System;

namespace Assets.Codebase.Presenter.Base
{
    public interface IPresenter
    {
        public event Action OnCloseView;

        public void CloseView();
    }
}
