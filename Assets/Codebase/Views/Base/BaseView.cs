using Assets.Codebase.Presenter.Base;
using Assets.Codebase.Presenters.Base;
using UniRx;
using UnityEngine;

namespace Assets.Codebase.Views.Base
{
    public abstract class BaseView : MonoBehaviour
    {
        protected IPresenter Presenter;

        public virtual void Init(IPresenter presenter)
        {
            Presenter = presenter;
            SubscribeToUserInput();
            SubscribeToPresenterEvents();
        }

        protected CompositeDisposable CompositeDisposable = new CompositeDisposable();

        protected virtual void OnEnable()
        {
        }

        protected virtual void OnDisable() 
        {
            CompositeDisposable.Dispose();
            Presenter.OnCloseView -= CloseView;
        }

        protected abstract void SubscribeToUserInput();
        protected virtual void SubscribeToPresenterEvents()
        {
            Presenter.OnCloseView += CloseView;
        }

        private void CloseView()
        {
            // Or other close logic
            Destroy(gameObject);
        }
    }
}