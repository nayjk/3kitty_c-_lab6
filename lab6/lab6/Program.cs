
class Animal
{
    string food;
    string location;
    string name;
    Animal animal;
    public void makeNoise()
    {
        
    }

    public void eat()
    {

    }

    public void sleep()
    {

    }

    public Animal(string food, string location, string name,Animal animal)
    {
        this.food = food;
        this.location = location;
        this.name = name;
        this.animal = animal;
    }
}

class Dog : Animal
{
    public Dog(string food,string location, string name) : base(food,location,name)
    {
        
    }
}

class Cat : Animal
{
    public Cat(string food, string location, string name) : base(food,location,name)
    {

    }
}

class Horse : Animal
{
    public Horse(string food,string location,string name) : base(food,location,name)
    {

    }
}

class Veterinar
{
    public Veterinar(string food, string location,string name) : base(food,location,name)
    {

    }

    public void treatAnimal(Animal animal)
    {
        Console.WriteLine()
    }
}