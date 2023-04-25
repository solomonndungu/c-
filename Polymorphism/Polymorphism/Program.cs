// Polymorphism
// Many forms - Type

Turtle turtle = new Turtle();

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Turtle : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("Turtle noise");
    }
}

