using UniRx;

namespace Assets.Codebase.Views.Base
{
    public abstract class BaseView
    {
        protected CompositeDisposable CompositeDisposable = new CompositeDisposable();
    }
}