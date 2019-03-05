/****************************************************
    文件：RenderSpriteSystem.cs
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
    public class RenderSpriteSystem : ReactiveSystem<GameEntity>
    {

        public RenderSpriteSystem(Contexts context) : base(context.game)
        {

        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Transform trans = entity.interactionExampleViewComponents.viewTransform;
                SpriteRenderer sr = trans.GetComponent<SpriteRenderer>();
                if (sr == null) trans.gameObject.AddComponent<SpriteRenderer>();
                sr.sprite = Resources.Load<Sprite>(entity.interactionExampleSpriteComponents.spriteName);
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionExampleSpriteComponents && entity.hasInteractionExampleViewComponents;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionExampleSpriteComponents);
        }
    }
}
