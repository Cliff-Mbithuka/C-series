class Program {
    class Person{
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor
        public Person(string name, int age){
            Name = name;
            Age = age;
        }

        static void Main(){
            Person person1 = new Person("Kazungu", 30);
            Person person2 = person1; //Reference to person1
            Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");

            //Modifying person2 will also modify person1
            person2.Name = "Kazungu Junior.";
            person2.Age = 1;
            Console.WriteLine("After modification");
            Console.WriteLine($"Person 1: {person1.Name}, Age: {person1.Age}");
            Console.WriteLine($"Person 2: {person2.Name}, Age: {person2.Age}");

        //arrays
        int[] numbers1 = {1, 2, 3, 4, 5};
        int[] numbers2 = numbers1; //Reference to numbers1

        Console.WriteLine("\n Reference Type: Arrays");
        Console.WriteLine("Numbers 1: " + string.Join(", ", numbers1));
        Console.WriteLine("Numbers 2: " + string.Join(", ", numbers2));

        //modifying numbers2 will also modify numbers1
        numbers2[0] = 10;
        Console.WriteLine("After modification");
        Console.WriteLine("Numbers 1: " + string.Join(", ", numbers1));
        Console.WriteLine("Numbers 2: " + string.Join(", ", numbers2));

        string str1 = "Hello";
        string str2 = str1; //Reference to str1

        Console.WriteLine("\n Reference Type: Strings");
        Console.WriteLine("String 1: " + str1);
        Console.WriteLine("String 2: " + str2);

        //modifying str2 will also modify str1
        str2 = "World";
        Console.WriteLine("After modification");    
        Console.WriteLine("String 1: " + str1);
        Console.WriteLine("String 2: " + str2);
        
        }
    }
}