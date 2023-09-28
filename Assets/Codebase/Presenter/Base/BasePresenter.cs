using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;
using Assets.Codebase.Presenter.Base;
using Assets.Codebase.Views.Base;

namespace Assets.Codebase.Presenters.Base
{
    public abstract class BasePresenter : IPresenter
    {
        protected IProgressModel ProgressModel;
        protected IGameplayModel GameplayModel;

        protected ViewId ViewId = ViewId.None;

        public void SetupModels(IProgressModel progressModel, IGameplayModel gameplayModel)
        {
            ProgressModel = progressModel;
            GameplayModel = gameplayModel;
        }

        public ViewId GetCorrespondingViewId()
        {
            return ViewId;
        }
    }
}
