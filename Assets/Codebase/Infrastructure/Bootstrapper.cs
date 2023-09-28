using Assets.Codebase.Utils.GOComponents;
using UnityEngine;

namespace Assets.Codebase.Infrastructure
{
    [RequireComponent(typeof(DontDestroyOnLoadComponent))]
    public class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            // Create MVP

            // RegisterServices

            // Start the game
        }
    }
}

