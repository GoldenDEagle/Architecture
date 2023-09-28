using Assets.Codebase.Presenter.Base;
using Assets.Codebase.Presenters.Base;
using UniRx;
using UnityEngine;

namespace Assets.Codebase.Views.Base
{
    public abstract class BaseView : MonoBehaviour
    {
        public virtual void Init(IPresenter presenter)
        {
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
        }

        protected abstract void SubscribeToUserInput();
        protected abstract void SubscribeToPresenterEvents();
    }
}