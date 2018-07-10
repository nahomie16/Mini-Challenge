using System;

namespace Do
{
    class Dog
    {
        enum Gender
        {
            Male,
            Female
        }
        // "If lost, call [owner]. ['Her'|'His'] name is [
        public String name = "";
        public int age;
        public String owner = "";
        Gender g; 
    

        Dog(String owner, String name, int age, Gender g)
        { //Constructor
            this.owner = owner;
            this.name = name;
            this.age = age;
            this.g = g; // gender enum  

        }
        public int bark(int num_barks)
        {
            for (int i = 0; i < num_barks; i++)
            {
                Console.WriteLine("Woof!");
            }
            return 0;
        }


        string getTag()
        {
            if (this.g == Gender.Male){
                if (this.age > 1)
                {
                    return $"If lost, call {this.name}. His name is  {this.owner} and he is {this.age} years old."; 

                }
                else { 
                  
                    return $"If lost, call {this.name}. His name is {this.owner} and he is {this.age} year old."; 
                }
            }
            else {   // Gender.Female 
                if (this.age > 1)
                {
                    return $"If lost, call {this.name}. Her name is  {this.owner} and she is {this.age}  years old."; 

                }
                else
                {

                    return $"If lost, call {this.name}. Her name is {this.owner} and she is {this.age}  year old."; 

                }
            }
        
        }

        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

         
        }

    }
}
