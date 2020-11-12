using System.Threading;
using JCMG.EntitasRedux;

namespace ExampleContent.Scenes.Visual_Debug_Bug
{
	public class SleepSystem : IUpdateSystem
	{
		private Contexts _contexts;

		public SleepSystem(Contexts contexts)
		{
			_contexts = contexts;
		}

		public void Update()
		{
			Thread.Sleep(100);
		}
	}
}
