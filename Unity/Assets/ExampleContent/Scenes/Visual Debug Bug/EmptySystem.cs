using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace ExampleContent.Scenes.Visual_Debug_Bug
{
	public class EmptySystem : ReactiveSystem<EmptyEntity> {
		private Contexts _contexts;

		public EmptySystem (Contexts contexts) : base(contexts.Empty) {
			_contexts = contexts;
		}

		protected override ICollector<EmptyEntity> GetTrigger(IContext<EmptyEntity> context) {
			return context.CreateCollector();
		}

		protected override bool Filter(EmptyEntity entity)
		{
			return true;
		}

		protected override void Execute(List<EmptyEntity> entities) {
			foreach (var e in entities) {
				// do stuff to the matched entities
			}
		}
	}
}
