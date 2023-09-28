using System;

namespace Assets.Codebase.Models.Progress.Data
{
    [Serializable]
    public class PersistantProgress
    {
        // All the same properties as ReactiveProgress, but Serializable
        public int Gold;

        public void SetValues(ReactiveProgress progress)
        {
            // Fill all properties
            Gold = progress.Gold.Value;
        }
    }
}
