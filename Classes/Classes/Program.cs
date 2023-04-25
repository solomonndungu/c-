// Classes
using Classes;

Dog dog = new Dog();
dog.Bark();
Console.WriteLine(dog.Name);
Console.WriteLine(dog.Age);

void Bark()
{
    Console.WriteLine("Bark");
}