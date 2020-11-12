using UnityEngine;

namespace ExampleContent.Scenes.Visual_Debug_Bug
{
	public class Controller : MonoBehaviour
	{
		private Systems _systems = null;

		private void Start()
		{
			_systems = new Systems(Contexts.SharedInstance);
		}

		private void Update()
		{
			_systems.Update();
			_systems.Execute();
		}
	}
}
