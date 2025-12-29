
    /*    Console.WriteLine("Hi, what is your name?");
        string name = Console.ReadLine()!;

        Console.WriteLine($"Nice to meet you, {name}! Welcome to practicing C#."); */



    class Person {
     public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; 
        Age = age;
    }
        public void Greet()
        { 
             Console.WriteLine($"Yeehaw, my name is {Name} and I am {Age} years old.");
       }
    } 
    class Program
    {
        static void Main()
        {  
    var person1 = new Person("Alex", 30);
    person1.Greet();

    var person2 = new Person("Sam", 25);    
    person2.Greet();  
        }
    }
    