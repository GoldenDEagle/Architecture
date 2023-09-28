using Assets.Codebase.Model.Gameplay.Data;
using UniRx;

namespace Assets.Codebase.Model.Gameplay
{
    /// <summary>
    /// Model responsible for game flow.
    /// </summary>
    public interface IGameplayModel
    {
        public ReactiveProperty<GameState> State { get; }

        public void ChangeGameState(GameState state);
    }
}
