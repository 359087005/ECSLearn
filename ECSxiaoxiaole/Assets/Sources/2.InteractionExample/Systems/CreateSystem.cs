/****************************************************
    文件：CreateSystem.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using System.Collections.Generic;
using Entitas;
using UnityEngine;
namespace InteractionExample
{
    public class CreateSystem : ReactiveSystem<InputEntity>
    {
        private GameContext gameContext;

        public CreateSystem(Contexts context) : base(context.input)
        {
            gameContext = context.game;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (InputEntity intity in entities)
            {
                gameContext.CreateEntity();
            }
                        
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.hasInteractionExampleMouseButtonComponents
                && entity.interactionExampleMouseButtonComponents.mouseButton == MouseButton.LEFT
                && entity.interactionExampleMouseButtonComponents.mouseButtonEvent == MouseButtonEvent.DOWN;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.InteractionExampleMouseButtonComponents);
        }
    }
}