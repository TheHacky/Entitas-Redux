//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugContext {

    public VisualDebugEntity UniqueEntity { get { return GetGroup(VisualDebugMatcher.Unique).GetSingleEntity(); } }
    public ExampleContent.VisualDebugging.UniqueComponent Unique { get { return UniqueEntity.Unique; } }
    public bool HasUnique { get { return UniqueEntity != null; } }

    public VisualDebugEntity SetUnique(string newValue) {
        if (HasUnique) {
            throw new JCMG.EntitasRedux.EntitasReduxException("Could not set Unique!\n" + this + " already has an entity with ExampleContent.VisualDebugging.UniqueComponent!",
                "You should check if the context already has a UniqueEntity before setting it or use context.ReplaceUnique().");
        }
        var entity = CreateEntity();
        entity.AddUnique(newValue);
        return entity;
    }

    public void ReplaceUnique(string newValue) {
        var entity = UniqueEntity;
        if (entity == null) {
            entity = SetUnique(newValue);
        } else {
            entity.ReplaceUnique(newValue);
        }
    }

    public void RemoveUnique() {
        UniqueEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.UniqueComponent Unique { get { return (ExampleContent.VisualDebugging.UniqueComponent)GetComponent(VisualDebugComponentsLookup.Unique); } }
    public bool HasUnique { get { return HasComponent(VisualDebugComponentsLookup.Unique); } }

    public void AddUnique(string newValue) {
        var index = VisualDebugComponentsLookup.Unique;
        var component = (ExampleContent.VisualDebugging.UniqueComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UniqueComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUnique(string newValue) {
        var index = VisualDebugComponentsLookup.Unique;
        var component = (ExampleContent.VisualDebugging.UniqueComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UniqueComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUnique() {
        RemoveComponent(VisualDebugComponentsLookup.Unique);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherUnique;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Unique {
        get {
            if (_matcherUnique == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Unique);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherUnique = matcher;
            }

            return _matcherUnique;
        }
    }
}