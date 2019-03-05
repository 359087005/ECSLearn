/****************************************************
    文件：InteractionController.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using Entitas;
using UnityEngine;

namespace InteractionExample
{
    public class InteractionController : MonoBehaviour
    {
        private Systems systems;
        private Contexts context;

        private void Start()
        {
            context = Contexts.sharedInstance;
            systems = CreatSystem(context);
        }

        private void Update()
        {
            systems.Execute();
            systems.Cleanup();
        }

        Systems CreatSystem(Contexts context)
        {
            return new Feature("System")
                .Add(new GameFeature(context))
                .Add(new InputFeature(context));
        }
    }
}
