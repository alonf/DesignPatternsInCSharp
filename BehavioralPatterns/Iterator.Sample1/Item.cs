namespace Iterator.Sample1;

// A collection item
class Item
{
	private string _name;

	// Constructor
	public Item(string name)
	{
		this._name = name;
	}

	// Gets name
	public string Name
	{
		get { return _name; }
	}
}

