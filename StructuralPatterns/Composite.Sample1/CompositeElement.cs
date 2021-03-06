namespace Composite.Sample1;

// The 'Composite' class
class CompositeElement : DrawingElement
{
	private List<DrawingElement> elements =
		 new List<DrawingElement>();

	// Constructor
	public CompositeElement(string name)
		: base(name)
	{
	}

	public override void Add(DrawingElement d)
	{
		elements.Add(d);
	}

	public override void Remove(DrawingElement d)
	{
		elements.Remove(d);
	}

	public override void Display(int indent)
	{
		Console.WriteLine(new String('-', indent) + "+ " + Name);

		// Display each child element on this node
		foreach (DrawingElement d in elements)
		{
			d.Display(indent + 2);
		}
	}
}

