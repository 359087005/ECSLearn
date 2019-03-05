/****************************************************
    文件：MouseSystem.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using Entitas;

namespace InteractionExample
{
    public class MouseSystem : IExecuteSystem,IInitializeSystem
    {
        private InputEntity inputEntity;
        private InputContext context;

        public MouseSystem(Contexts contexts)
        {
            context = contexts.input;
        }


        void IInitializeSystem.Initialize()
        {
            inputEntity = context.interactionExampleMouseButtonComponentsEntity;
        }

        void IExecuteSystem.Execute()
        {
            if (Input.GetMouseButtonDown(0))
            {
                context.ReplaceInteractionExampleMouseButtonComponents(MouseButton.LEFT,MouseButtonEvent.DOWN);
            }
            if (Input.GetMouseButtonDown(1))
            {
                context.ReplaceInteractionExampleMouseButtonComponents(MouseButton.RIGHT, MouseButtonEvent.DOWN);
            }
        }

    }
}