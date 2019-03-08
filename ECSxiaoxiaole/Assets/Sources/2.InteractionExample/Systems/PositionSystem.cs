/****************************************************
    文件：PositionSystem.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
using Entitas;
using System;
using System.Collections.Generic;

namespace InteractionExample
{
    public class PositionSystem : ReactiveSystem<GameEntity>
    {

        public PositionSystem(Contexts context) : base(context.game)
        {
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionExamplePositionComponents
                && entity.hasInteractionExampleViewComponents;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionExamplePositionComponents);
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity gameEntity in entities)
            {
                gameEntity.interactionExampleViewComponents.viewTransform.position
                    = gameEntity.interactionExamplePositionComponents.pos;
            }
        }
    }
}