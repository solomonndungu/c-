using System;
namespace Classes
{
	public class Dog
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public Dog()
		{
			Name = "Turtle";
			Age = 10;
		}

		public void Bark()
		{
			Console.WriteLine("Bark");
		}
		
	}
}

