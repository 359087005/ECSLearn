//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity interactionExampleMouseButtonComponentsEntity { get { return GetGroup(InputMatcher.InteractionExampleMouseButtonComponents).GetSingleEntity(); } }
    public InteractionExample.MouseButtonComponents interactionExampleMouseButtonComponents { get { return interactionExampleMouseButtonComponentsEntity.interactionExampleMouseButtonComponents; } }
    public bool hasInteractionExampleMouseButtonComponents { get { return interactionExampleMouseButtonComponentsEntity != null; } }

    public InputEntity SetInteractionExampleMouseButtonComponents(MouseButton newMouseButton, MouseButtonEvent newMouseButtonEvent) {
        if (hasInteractionExampleMouseButtonComponents) {
            throw new Entitas.EntitasException("Could not set InteractionExampleMouseButtonComponents!\n" + this + " already has an entity with InteractionExample.MouseButtonComponents!",
                "You should check if the context already has a interactionExampleMouseButtonComponentsEntity before setting it or use context.ReplaceInteractionExampleMouseButtonComponents().");
        }
        var entity = CreateEntity();
        entity.AddInteractionExampleMouseButtonComponents(newMouseButton, newMouseButtonEvent);
        return entity;
    }

    public void ReplaceInteractionExampleMouseButtonComponents(MouseButton newMouseButton, MouseButtonEvent newMouseButtonEvent) {
        var entity = interactionExampleMouseButtonComponentsEntity;
        if (entity == null) {
            entity = SetInteractionExampleMouseButtonComponents(newMouseButton, newMouseButtonEvent);
        } else {
            entity.ReplaceInteractionExampleMouseButtonComponents(newMouseButton, newMouseButtonEvent);
        }
    }

    public void RemoveInteractionExampleMouseButtonComponents() {
        interactionExampleMouseButtonComponentsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public InteractionExample.MouseButtonComponents interactionExampleMouseButtonComponents { get { return (InteractionExample.MouseButtonComponents)GetComponent(InputComponentsLookup.InteractionExampleMouseButtonComponents); } }
    public bool hasInteractionExampleMouseButtonComponents { get { return HasComponent(InputComponentsLookup.InteractionExampleMouseButtonComponents); } }

    public void AddInteractionExampleMouseButtonComponents(MouseButton newMouseButton, MouseButtonEvent newMouseButtonEvent) {
        var index = InputComponentsLookup.InteractionExampleMouseButtonComponents;
        var component = (InteractionExample.MouseButtonComponents)CreateComponent(index, typeof(InteractionExample.MouseButtonComponents));
        component.mouseButton = newMouseButton;
        component.mouseButtonEvent = newMouseButtonEvent;
        AddComponent(index, component);
    }

    public void ReplaceInteractionExampleMouseButtonComponents(MouseButton newMouseButton, MouseButtonEvent newMouseButtonEvent) {
        var index = InputComponentsLookup.InteractionExampleMouseButtonComponents;
        var component = (InteractionExample.MouseButtonComponents)CreateComponent(index, typeof(InteractionExample.MouseButtonComponents));
        component.mouseButton = newMouseButton;
        component.mouseButtonEvent = newMouseButtonEvent;
        ReplaceComponent(index, component);
    }

    public void RemoveInteractionExampleMouseButtonComponents() {
        RemoveComponent(InputComponentsLookup.InteractionExampleMouseButtonComponents);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherInteractionExampleMouseButtonComponents;

    public static Entitas.IMatcher<InputEntity> InteractionExampleMouseButtonComponents {
        get {
            if (_matcherInteractionExampleMouseButtonComponents == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.InteractionExampleMouseButtonComponents);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherInteractionExampleMouseButtonComponents = matcher;
            }

            return _matcherInteractionExampleMouseButtonComponents;
        }
    }
}