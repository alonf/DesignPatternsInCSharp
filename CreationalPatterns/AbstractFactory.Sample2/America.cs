namespace AbstractFactory.Sample2;

/// <summary>
/// The 'ConcreteFactory2' class.
/// </summary>
class America : IContinentFactory
	{
		public IHerbivore CreateHerbivore()
		{
			return new Bison();
		}

		public ICarnivore CreateCarnivore()
		{
			return new Wolf();
		}
	}

