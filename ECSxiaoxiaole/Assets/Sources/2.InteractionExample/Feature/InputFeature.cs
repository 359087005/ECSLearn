/****************************************************
    文件：InputFeature.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;
namespace InteractionExample
{
    public class InputFeature : Feature
    {
        public InputFeature(Contexts context)
        {
            Add(new MouseSystem(context));
            Add(new CreateSystem(context));
        }
    }
}