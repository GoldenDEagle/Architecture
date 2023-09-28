using Assets.Codebase.Models.Progress.Data;

namespace Assets.Codebase.Models.Progress
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
