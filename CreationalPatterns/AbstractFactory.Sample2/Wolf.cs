namespace AbstractFactory.Sample2;

/// <summary>
/// The 'ProductB2' class
/// </summary>
class Wolf : ICarnivore
	{
		public void Eat(IHerbivore h)
		{
			// Eat Bison
			Console.WriteLine(this.GetType().Name +
				 " eats " + h.GetType().Name);
		}
	}

