namespace Lab5;
// Step 1 //
public class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
// Step 2 //
public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}
public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
// Step 3 //
class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal();
        Animal a2 = new Cat();
        Animal a3 = new Dog();

        a1.animalSound();
        a2.animalSound();
        a3.animalSound();
    }
}
