using Assets.Codebase.Infrastructure.ServicesManagment;
using Assets.Codebase.Infrastructure.ServicesManagment.Ads;
using Assets.Codebase.Infrastructure.ServicesManagment.Assets;
using Assets.Codebase.Infrastructure.ServicesManagment.ViewCreation;
using Assets.Codebase.Models.Gameplay;
using Assets.Codebase.Models.Progress;
using Assets.Codebase.Presenters.Base;
using Assets.Codebase.Presenters.Example;
using Assets.Codebase.Utils.GOComponents;
using Assets.Codebase.Views.Base;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Infrastructure
{
    [RequireComponent(typeof(DontDestroyOnLoadComponent))]
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private RectTransform _uiRoot;

        private IProgressModel _progressModel;
        private IGameplayModel _gameplayModel;
        private List<BasePresenter> _presenters;

        private void Awake()
        {
            InitMVPStructure();

            RegisterServices();

            // Start the game
            ServiceLocator.Container.Single<IViewCreatorService>().CreateView(ViewId.ExampleView);
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

        private void RegisterServices()
        {
            var services = ServiceLocator.Container;

            services.RegisterSingle<IAssetProvider>(new AssetProvider());
            services.RegisterSingle<IViewCreatorService>(new ViewCreatorService(services.Single<IAssetProvider>(), _presenters, _uiRoot));
            services.RegisterSingle<IAdsService>(new GamePushAdService());
        }
    }
}

