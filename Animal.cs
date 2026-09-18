public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }


    public void Sleep()
    {
        Console.WriteLine("Animal is Sleeping");
    }

}

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