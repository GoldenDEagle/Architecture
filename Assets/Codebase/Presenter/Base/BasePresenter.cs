using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;
using Assets.Codebase.Presenter.Base;
using Assets.Codebase.Views.Base;
using System;
using System.Security.Cryptography;

namespace Assets.Codebase.Presenters.Base
{
    public abstract class BasePresenter : IPresenter
    {
        protected IProgressModel ProgressModel;
        protected IGameplayModel GameplayModel;

        /// <summary>
        /// Corresponding view Id.
        /// </summary>
        protected ViewId ViewId = ViewId.None;

        public event Action OnCloseView;

        /// <summary>
        /// Creates binding to models.
        /// </summary>
        /// <param name="progressModel"></param>
        /// <param name="gameplayModel"></param>
        public void SetupModels(IProgressModel progressModel, IGameplayModel gameplayModel)
        {
            ProgressModel = progressModel;
            GameplayModel = gameplayModel;
        }

        public void CloseView()
        {
            OnCloseView?.Invoke();
        }

        /// <summary>
        /// Gets ID of corresponding view.
        /// </summary>
        /// <returns></returns>
        public ViewId GetCorrespondingViewId()
        {
            return ViewId;
        }
    }
}
