/****************************************************
    文件：InteractionFeature.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;

namespace InteractionExample
{
    public class GameFeature : Feature
    {
        public GameFeature(Contexts contexts)
        {
            Add(new AddViewSystem(contexts));
            Add(new RenderSpriteSystem(contexts));
        }
    }
}