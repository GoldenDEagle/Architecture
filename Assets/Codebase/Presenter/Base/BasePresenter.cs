using Assets.Codebase.Model.Gameplay;
using Assets.Codebase.Model.Progress;

namespace Assets.Codebase.Presenter.Base
{
    public abstract class BasePresenter
    {
        protected IProgressModel ProgressModel;
        protected IGameplayModel GameplayModel;

        public BasePresenter(IProgressModel progressModel, IGameplayModel gameplayModel) 
        { 
            ProgressModel = progressModel;
            GameplayModel = gameplayModel;
        }
    }
}
