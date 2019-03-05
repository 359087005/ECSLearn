/****************************************************
    文件：MouseButtonComponents.cs
	作者：ICE
    邮箱: 359087005@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace InteractionExample
{
    /// <summary>
    /// 鼠标事件
    /// </summary>
    [Input,Unique]
    public class MouseButtonComponents : IComponent
    {
        public MouseButton mouseButton;

        public MouseButtonEvent mouseButtonEvent;
    }
}
