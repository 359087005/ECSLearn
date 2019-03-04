using Entitas;


namespace HelloWorld
{
    public class AddGameSystems : Feature
    {
        public AddGameSystems(Contexts context) : base("AddGameSystems")
        {
            Add(new LogSystem(context));
            Add(new InitSystem(context));
        }
    }
}
