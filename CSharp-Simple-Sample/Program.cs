class Animal
{
    public virtual void EmitSound()
    {
        Console.WriteLine("Animal making noise");
    }
}

class Dog : Animal
{
    public override void EmitSound()
    {
        Console.WriteLine("Woo wow!");
    }
}

class Cat : Animal
{
    public override void EmitSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void MakeNoise(Animal animal)
    {
        animal.EmitSound();
    }

    static void Main()
    {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        MakeNoise(animal1);
        MakeNoise(animal2);
    }
}
