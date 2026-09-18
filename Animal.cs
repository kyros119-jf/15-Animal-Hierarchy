// Base class contains behaviors shared by all animals
public class Animal
{
    public void Eat()
    {
        Console.WriteLine($"{this.GetType().Name} is Eating");
    }


    public void Sleep()
    {
        Console.WriteLine($"{this.GetType().Name} is Sleeping");
    }

}
// Dog inherits Eat() and Sleep() from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

public class Cat : Animal
{

    public void Meow()
    {
        Console.WriteLine("Cat Meows");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Bird Flies");
    }
}