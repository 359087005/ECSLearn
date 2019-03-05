//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InteractionExample.RotationComponents interactionExampleRotationComponents { get { return (InteractionExample.RotationComponents)GetComponent(GameComponentsLookup.InteractionExampleRotationComponents); } }
    public bool hasInteractionExampleRotationComponents { get { return HasComponent(GameComponentsLookup.InteractionExampleRotationComponents); } }

    public void AddInteractionExampleRotationComponents(float newRotation) {
        var index = GameComponentsLookup.InteractionExampleRotationComponents;
        var component = (InteractionExample.RotationComponents)CreateComponent(index, typeof(InteractionExample.RotationComponents));
        component.rotation = newRotation;
        AddComponent(index, component);
    }

    public void ReplaceInteractionExampleRotationComponents(float newRotation) {
        var index = GameComponentsLookup.InteractionExampleRotationComponents;
        var component = (InteractionExample.RotationComponents)CreateComponent(index, typeof(InteractionExample.RotationComponents));
        component.rotation = newRotation;
        ReplaceComponent(index, component);
    }

    public void RemoveInteractionExampleRotationComponents() {
        RemoveComponent(GameComponentsLookup.InteractionExampleRotationComponents);
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

    static Entitas.IMatcher<GameEntity> _matcherInteractionExampleRotationComponents;

    public static Entitas.IMatcher<GameEntity> InteractionExampleRotationComponents {
        get {
            if (_matcherInteractionExampleRotationComponents == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InteractionExampleRotationComponents);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractionExampleRotationComponents = matcher;
            }

            return _matcherInteractionExampleRotationComponents;
        }
    }
}