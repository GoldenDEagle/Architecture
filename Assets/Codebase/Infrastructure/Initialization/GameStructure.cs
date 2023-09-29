using Assets.Codebase.Infrastructure.ServicesManagment.Ads;
using Assets.Codebase.Infrastructure.ServicesManagment.Assets;
using Assets.Codebase.Infrastructure.ServicesManagment.ViewCreation;
using Assets.Codebase.Infrastructure.ServicesManagment;
using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;
using Assets.Codebase.Presenters.Base;
using Assets.Codebase.Presenters.Example;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Infrastructure.Initialization
{
    /// <summary>
    /// Responsible for creation of game structure.
    /// </summary>
    public class GameStructure
    {
        public static bool IsGameInitialized = false;

        // Needed from outside
        private RectTransform _uiRoot;

        // Created inside
        private IProgressModel _progressModel;
        private IGameplayModel _gameplayModel;
        private List<BasePresenter> _presenters;

        public GameStructure(RectTransform uiRoot)
        {
            _uiRoot = uiRoot;

            InitMVPStructure();
            RegisterServices();

            IsGameInitialized = true;
        }

        private void InitMVPStructure()
        {
            CreateModels();
            CreatePresenters();
        }

        private void CreateModels()
        {
            _progressModel = new LocalProgressModel();
            _gameplayModel = new GameplayModel();
        }

        private void CreatePresenters()
        {
            // Create presenter for each view
            _presenters = new List<BasePresenter>();
            _presenters.Add(new ExamplePresenter());

            foreach (var presenter in _presenters)
            {
                presenter.SetupModels(_progressModel, _gameplayModel);
            }
        }

        /// <summary>
        /// Registering all game services.
        /// </summary>
        private void RegisterServices()
        {
            var services = ServiceLocator.Container;

            services.RegisterSingle<IAssetProvider>(new AssetProvider());
            services.RegisterSingle<IViewCreatorService>(new ViewCreatorService(services.Single<IAssetProvider>(), _presenters, _uiRoot));
            services.RegisterSingle<IAdsService>(new GamePushAdService());
        }
    }
}
