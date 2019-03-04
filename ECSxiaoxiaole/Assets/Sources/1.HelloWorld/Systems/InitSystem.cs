using System;
using Entitas;
namespace HelloWorld
{
    public class InitSystem : IInitializeSystem
    {
        private readonly GameContext _gameContext;

        public InitSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
        }

        public void Initialize()
        {
            _gameContext.CreateEntity().AddHelloWorldLog("Hello World");
        }
    }
}
