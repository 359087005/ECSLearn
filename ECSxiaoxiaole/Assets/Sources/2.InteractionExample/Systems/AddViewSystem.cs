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

public class AddViewSystem : ReactiveSystem<GameEntity>
{
    public AddViewSystem(Contexts context) : base(context.game)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        throw new System.NotImplementedException();
    }

    protected override bool Filter(GameEntity entity)
    {
        throw new System.NotImplementedException();
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        throw new System.NotImplementedException();
    }
}