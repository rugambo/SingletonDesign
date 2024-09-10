using SingletonDesign;

internal class Program
{
    private static void Main(string[] args)
    {
        //create an instance of a Person class and see is another instance is created

        Person person0 = Person.Instance;
        Person person1 = Person.Instance;   

        //Check to see if an instance has been created
        Console.WriteLine(person0);
        //Now call person1 is another instance or the same 
        Console.WriteLine(person1);
        if (person0 == person1)
        {
            Console.WriteLine("The same instance.");
        }
        else
        {
            Console.WriteLine("System broken");
        }

    }
}