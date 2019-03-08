/****************************************************
    文件：AddViewSystem.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：添加视图系统
*****************************************************/

using UnityEngine;
using Entitas;
using System.Collections.Generic;
using Entitas.Unity;
namespace InteractionExample
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private Transform parent;
        private Contexts _context;

        public AddViewSystem(Contexts context) : base(context.game)
        {
            parent = new GameObject("ViewParent").transform;
            _context = context;
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionExampleSpriteComponents && !entity.hasInteractionExampleViewComponents;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionExampleSpriteComponents);
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                GameObject go = new GameObject("View");
                go.transform.SetParent(parent);
                go.Link(entity);
                entity.AddInteractionExampleViewComponents(go.transform);
            }
        }
    }
}