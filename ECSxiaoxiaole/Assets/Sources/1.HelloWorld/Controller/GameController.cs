using Entitas;
using UnityEngine;

namespace HelloWorld
{
    class GameController : MonoBehaviour
    {
        private Systems _systems;
        private void Start()
        {
            var context = Contexts.sharedInstance;

            _systems = new Feature("Systems").Add(new AddGameSystems(context));
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
