//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.DictArrayComponent DictArray { get { return (ExampleContent.VisualDebugging.DictArrayComponent)GetComponent(VisualDebugComponentsLookup.DictArray); } }
	public bool HasDictArray { get { return HasComponent(VisualDebugComponentsLookup.DictArray); } }

	public void AddDictArray(System.Collections.Generic.Dictionary<int, string[]> newDict, System.Collections.Generic.Dictionary<int, ExampleContent.VisualDebugging.CustomObject[]> newDictRefArrayType, System.Collections.Generic.Dictionary<int, string[]>[] newDictArray)
	{
		var index = VisualDebugComponentsLookup.DictArray;
		var component = (ExampleContent.VisualDebugging.DictArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dict = newDict;
		component.dictRefArrayType = newDictRefArrayType;
		component.dictArray = newDictArray;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceDictArray(System.Collections.Generic.Dictionary<int, string[]> newDict, System.Collections.Generic.Dictionary<int, ExampleContent.VisualDebugging.CustomObject[]> newDictRefArrayType, System.Collections.Generic.Dictionary<int, string[]>[] newDictArray)
	{
		var index = VisualDebugComponentsLookup.DictArray;
		var component = (ExampleContent.VisualDebugging.DictArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dict = newDict;
		component.dictRefArrayType = newDictRefArrayType;
		component.dictArray = newDictArray;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyDictArrayTo(ExampleContent.VisualDebugging.DictArrayComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.DictArray;
		var component = (ExampleContent.VisualDebugging.DictArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dict = (System.Collections.Generic.Dictionary<int, string[]>)JCMG.EntitasRedux.DictionaryTools.DeepCopy(copyComponent.dict);
		component.dictRefArrayType = (System.Collections.Generic.Dictionary<int, ExampleContent.VisualDebugging.CustomObject[]>)JCMG.EntitasRedux.DictionaryTools.DeepCopyArrayValue(copyComponent.dictRefArrayType);
		component.dictArray = (System.Collections.Generic.Dictionary<int, string[]>[])copyComponent.dictArray.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveDictArray()
	{
		RemoveComponent(VisualDebugComponentsLookup.DictArray);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.3.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherDictArray;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> DictArray
	{
		get
		{
			if (_matcherDictArray == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.DictArray);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherDictArray = matcher;
			}

			return _matcherDictArray;
		}
	}
}
