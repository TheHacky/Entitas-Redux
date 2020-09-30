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
	public ExampleContent.VisualDebugging.JaggedArrayComponent JaggedArray { get { return (ExampleContent.VisualDebugging.JaggedArrayComponent)GetComponent(VisualDebugComponentsLookup.JaggedArray); } }
	public bool HasJaggedArray { get { return HasComponent(VisualDebugComponentsLookup.JaggedArray); } }

	public void AddJaggedArray(string[][] newJaggedArray)
	{
		var index = VisualDebugComponentsLookup.JaggedArray;
		var component = (ExampleContent.VisualDebugging.JaggedArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.JaggedArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.jaggedArray = newJaggedArray;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceJaggedArray(string[][] newJaggedArray)
	{
		var index = VisualDebugComponentsLookup.JaggedArray;
		var component = (ExampleContent.VisualDebugging.JaggedArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.JaggedArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.jaggedArray = newJaggedArray;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyJaggedArrayTo(ExampleContent.VisualDebugging.JaggedArrayComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.JaggedArray;
		var component = (ExampleContent.VisualDebugging.JaggedArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.JaggedArrayComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.jaggedArray = (string[][])JCMG.EntitasRedux.ArrayTools.DeepCopy(copyComponent.jaggedArray);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveJaggedArray()
	{
		RemoveComponent(VisualDebugComponentsLookup.JaggedArray);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherJaggedArray;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> JaggedArray
	{
		get
		{
			if (_matcherJaggedArray == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.JaggedArray);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherJaggedArray = matcher;
			}

			return _matcherJaggedArray;
		}
	}
}
