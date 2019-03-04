/****************************************************
    文件：LogSystem.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace HelloWorld
{
    public class LogSystem : ReactiveSystem<GameEntity>
    {
        public LogSystem(Contexts contexts) : base(contexts.game)
        {

        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasHelloWorldLog;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.HelloWorldLog);
        }
        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Debug.Log(entity.helloWorldLog.message);
            }
        }
    }
}