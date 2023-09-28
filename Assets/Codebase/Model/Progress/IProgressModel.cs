using Assets.Codebase.Model.Progress.Data;

namespace Assets.Codebase.Model.Progress
{
    /// <summary>
    /// Model that contains all data that needs to be saved.
    /// </summary>
    public interface IProgressModel
    {
        public ReactiveProgress ReactiveProgress { get; }
        public void SaveProgress();
        public void LoadProgress();
    }
}
