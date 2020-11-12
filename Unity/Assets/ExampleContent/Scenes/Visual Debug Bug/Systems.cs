namespace ExampleContent.Scenes.Visual_Debug_Bug
{
	public class Systems : Feature
	{
		public Systems(Contexts contexts) : base("Bug Systems")
		{
			Add(new EmptySystem(contexts));
			Add(new SleepSystem(contexts));
		}
	}
}
