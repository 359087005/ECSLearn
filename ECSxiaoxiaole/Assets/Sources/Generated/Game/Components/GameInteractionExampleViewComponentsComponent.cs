//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InteractionExample.ViewComponents interactionExampleViewComponents { get { return (InteractionExample.ViewComponents)GetComponent(GameComponentsLookup.InteractionExampleViewComponents); } }
    public bool hasInteractionExampleViewComponents { get { return HasComponent(GameComponentsLookup.InteractionExampleViewComponents); } }

    public void AddInteractionExampleViewComponents(UnityEngine.Transform newViewTransform) {
        var index = GameComponentsLookup.InteractionExampleViewComponents;
        var component = (InteractionExample.ViewComponents)CreateComponent(index, typeof(InteractionExample.ViewComponents));
        component.viewTransform = newViewTransform;
        AddComponent(index, component);
    }

    public void ReplaceInteractionExampleViewComponents(UnityEngine.Transform newViewTransform) {
        var index = GameComponentsLookup.InteractionExampleViewComponents;
        var component = (InteractionExample.ViewComponents)CreateComponent(index, typeof(InteractionExample.ViewComponents));
        component.viewTransform = newViewTransform;
        ReplaceComponent(index, component);
    }

    public void RemoveInteractionExampleViewComponents() {
        RemoveComponent(GameComponentsLookup.InteractionExampleViewComponents);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInteractionExampleViewComponents;

    public static Entitas.IMatcher<GameEntity> InteractionExampleViewComponents {
        get {
            if (_matcherInteractionExampleViewComponents == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InteractionExampleViewComponents);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractionExampleViewComponents = matcher;
            }

            return _matcherInteractionExampleViewComponents;
        }
    }
}