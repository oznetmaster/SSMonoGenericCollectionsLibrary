
namespace MySpace
	{
	public class Class1<TKey, TValue>
		{
		class Node
			{
			public TKey key;
			public TValue value;

			public Node (TKey key, TValue value)
				{
				this.key = key;
				this.value = value;
				}
			}

		private Node a;

		public Class1 (TKey key, TValue value)
			{
			a = new Node (key, value);
			}
		}
	}