using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ExampleContent.VisualDebugging
{
	public class VisualDebuggingExampleController : MonoBehaviour
	{
		private void Start()
		{
			var context = Contexts.SharedInstance.VisualDebug;

			CreateTestGroups(context);

			CreateTestEntities(context);
			CreateTestEntityWithNullValues(context);

			CreateTestEntityError(context);
		}

		private void CreateTestGroups(VisualDebugContext context)
		{
			context.GetGroup(VisualDebugMatcher.Vector3);
			context.GetGroup(VisualDebugMatcher.GameObject);
			context.GetGroup(Matcher<VisualDebugEntity>.AllOf(VisualDebugMatcher.GameObject, VisualDebugMatcher.Vector3));
			context.GetGroup(Matcher<VisualDebugEntity>.AllOf(VisualDebugMatcher.GameObject, VisualDebugMatcher.Vector3));
		}

		private void CreateTestEntities(VisualDebugContext context)
		{
			for (var i = 0; i < 2; i++)
			{
				var e = context.CreateEntity();

				// Unity's builtIn
				e.AddBounds(new Bounds());
				e.AddColor(Color.red);
				e.AddAnimationCurve(
					AnimationCurve.EaseInOut(
						0f,
						0f,
						1f,
						1f));
				e.AddMyEnum(MyEnumComponent.MyEnum.Item2);
				e.AddMyFlags(MyFlagsComponent.MyFlags.Item2);
				e.AddMyDouble(4.2f);
				e.AddMyFloat(4.2f);
				e.AddMyInt(42);
				e.AddMyHiddenInt(42);
				e.AddRect(
					new Rect(
						1f,
						2f,
						3f,
						4f));
				e.AddMyString("Hello, world!");
				e.AddVector2(new Vector2(1f, 2f));
				e.AddVector3(new Vector3(1f, 2f, 3f));
				e.AddVector4(
					new Vector4(
						1f,
						2f,
						3f,
						4f));
				e.AddMyBool(true);
				e.AddUnityObject(new Object());
				var go = new GameObject("Player");
				go.Link(e);
				e.AddGameObject(go);
				e.AddTexture(new CustomRenderTexture(32, 32));
				e.AddTexture2D(new Texture2D(2, 2));

				// Custom
				e.IsFlag = true;
				e.MyCustomFlag = true;
				e.AddMonoBehaviourSubClass(new GameObject().AddComponent<MonoBehaviourSubClass>());
				e.AddCustomObject(new CustomObject("Custom Object"));
				e.AddSystemObject(new object());
				e.AddDateTime(DateTime.Now);
				e.AddAnArray(
					new[]
					{
						"Hello",
						", ",
						"world",
						"!"
					});
				e.AddArray2D(new string[2, 3]);
				e.AddArray3D(new string[2, 3, 4]);
				var jaggedArray = new string[2][];
				jaggedArray[0] = new[]
				{
					"Entity",
					"Component",
					"System"
				};
				jaggedArray[1] = new[]
				{
					"For",
					"C#"
				};
				e.AddJaggedArray(jaggedArray);
				var listArray = new[]
				{
					new List<string>
					{
						"1", "2", "3"
					},
					new List<string>
					{
						"One", "Two", "Three"
					}
				};
				e.AddListArray(listArray);
				e.AddList(
					new List<string>
					{
						"Apple", "Banana", "Peach"
					});
				var dict = new Dictionary<string, string>
				{
					{
						"1", "One"
					},
					{
						"2", "Two"
					},
					{
						"3", "Three"
					},
					{
						"4", "One"
					},
					{
						"5", "Two"
					},
					{
						"6", "Three"
					},
					{
						"7", "One"
					},
					{
						"8", "Two"
					},
					{
						"9", "Three"
					}
				};
				e.AddDictionary(dict);
				var dict2 = new Dictionary<int, string[]>
				{
					{
						1, new[]
						{
							"One",
							"Two",
							"Three"
						}
					},
					{
						2, new[]
						{
							"Four",
							"Five",
							"Six"
						}
					},
					{
						3, new[]
						{
							"One",
							"Two",
							"Three"
						}
					},
					{
						4, new[]
						{
							"Four",
							"Five",
							"Six"
						}
					},
					{
						5, new[]
						{
							"One",
							"Two",
							"Three"
						}
					},
					{
						6, new[]
						{
							"Four",
							"Five",
							"Six"
						}
					},
					{
						7, new[]
						{
							"One",
							"Two",
							"Three"
						}
					}
				};
				var dictArray = new[]
				{
					new Dictionary<int, string[]>
					{
						{
							1, new[]
							{
								"One",
								"Two",
								"Three"
							}
						},
						{
							2, new[]
							{
								"Four",
								"Five",
								"Six"
							}
						}
					},
					new Dictionary<int, string[]>
					{
						{
							3, new[]
							{
								"One",
								"Two",
								"Three"
							}
						},
						{
							4, new[]
							{
								"Four",
								"Five",
								"Six"
							}
						}
					}
				};
				var dictComplexObject = new Dictionary<int, CustomObject[]>
				{
					{ 1, new []{ new CustomObject("John"), new CustomObject("Jane") }},
					{ 2, new []{ new CustomObject("Jack"), new CustomObject("Jill") }}
				};
				e.AddDictArray(dict2, dictComplexObject, dictArray);
				e.AddHashSet(
					new HashSet<string>
					{
						"One", "Two", "Three"
					});
				e.AddMyChar('c');
				e.AddUnsupportedObject(new UnsupportedObject("Unsupported Object"));
				e.AddSimpleObject(new SimpleObject());
				e.AddDontDrawSimpleObject(new SimpleObject());
				e.AddProperty("My Property");
				e.AddPerson("Male", "Max");
				e.AddManyMembers(
					"1",
					"2",
					"3",
					"4",
					"5",
					"6",
					"7",
					"8",
					"9",
					"10",
					"11",
					"12");
			}
		}

		private void CreateTestEntityWithNullValues(VisualDebugContext context)
		{
			var e = context.CreateEntity();

			// Unity's builtIn
			AnimationCurve animationCurve = null;
			e.AddAnimationCurve(animationCurve);
			string myString = null;
			e.AddMyString(myString);
			Object unityObject = null;
			e.AddUnityObject(unityObject);
			GameObject go = null;
			e.AddGameObject(go);
			Texture texture = null;
			e.AddTexture(texture);
			Texture2D texture2D = null;
			e.AddTexture2D(texture2D);

			// Custom
			MonoBehaviourSubClass monoBehaviourSubClass = null;
			e.AddMonoBehaviourSubClass(monoBehaviourSubClass);
			CustomObject customObject = null;
			e.AddCustomObject(customObject);
			object systemObject = null;
			e.AddSystemObject(systemObject);
			string[] array = null;
			e.AddAnArray(array);
			string[,] array2d = null;
			e.AddArray2D(array2d);
			string[,,] array3d = null;
			e.AddArray3D(array3d);
			string[][] jaggedArray = null;
			e.AddJaggedArray(jaggedArray);
			List<string>[] listArray = null;
			e.AddListArray(listArray);
			List<string> list = null;
			e.AddList(list);
			Dictionary<string, string> dict = null;
			e.AddDictionary(dict);
			Dictionary<int, string[]> dict2 = null;
			Dictionary<int, CustomObject[]> dictComplexObject = null;
			Dictionary<int, string[]>[] dictArray = null;
			e.AddDictArray(dict2, dictComplexObject, dictArray);
			HashSet<string> hashset = null;
			e.AddHashSet(hashset);
			char c = default;
			e.AddMyChar(c);
			UnsupportedObject unsupportedObject = null;
			e.AddUnsupportedObject(unsupportedObject);
			SimpleObject simpleObject = null;
			e.AddSimpleObject(simpleObject);
			e.AddDontDrawSimpleObject(simpleObject);
			e.AddProperty(myString);
			string personName = null;
			string personGender = null;
			e.AddPerson(personName, personGender);
		}

		private void CreateTestEntityError(VisualDebugContext context)
		{
			var entity = context.CreateEntity();
			entity.Retain(this);
			entity.Destroy();
		}
	}
}
