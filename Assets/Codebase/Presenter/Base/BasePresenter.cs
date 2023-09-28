using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;

namespace Assets.Codebase.Presenters.Base
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
