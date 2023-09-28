using Assets.Codebase.Views.Base;

namespace Assets.Codebase.Infrastructure.ServicesManagment.ViewCreation
{
    public interface IViewCreatorService : IService
    {
        public void CreateView(ViewId viewId);
    }
}
