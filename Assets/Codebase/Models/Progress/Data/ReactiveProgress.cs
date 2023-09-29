using UniRx;

namespace Assets.Codebase.Models.Progress.Data
{
    public class ReactiveProgress
    {
        // All the properties that need to be saved...

        public ReactiveProperty<int> Gold;

        // .

        /// <summary>
        /// Creates new progress with default values.
        /// </summary>
        public ReactiveProgress()
        {
            Gold = new ReactiveProperty<int>(0);
        }

        /// <summary>
        /// Creates new progress from persistant data.
        /// </summary>
        /// <param name="progress"></param> Progress to initialize from
        public ReactiveProgress(PersistantProgress progress)
        {
            Gold = new ReactiveProperty<int>(progress.Gold);
        }
    }
}
