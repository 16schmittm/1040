using System;

namespace Dog
{
    
    
        enum Gender
            {
                Male,
                Female
            }
        class Dog
        {
            protected string name;
            protected string owner;
            protected int age;
            protected Gender gender;
            public Dog (string newName, string newOwner, int newAge, Gender newGender)
            {
                name=newName;
                owner=newOwner;
                age=newAge;
                gender=newGender;
            }
            public void Bark(int noise)
            {
                for (int count=0; count<noise;count++)
                {
                    Console.WriteLine("Woof!");
                }
                Console.ReadLine();
            }
            public void GetTag()
            {
                string a;
                string b;
                string c;

                if (gender==Gender.Male)
                {
                    a="His";
                    b="He";
                }
                else
                {
                    a="Her";
                    b="She";
                }
                if (age==1)
                {
                    c="Year";
                }
                else
                {
                    c="Years";
                }
                Console.WriteLine("If lost, call " + owner + ". " + a + " " + "name is " + name + " and " + b + " is " + age.ToString() + " " + c + " old.");
                Console.ReadLine();
            }
        }

    class MainProgram
    {
        static void Main(string[] args)
        { 
         Dog x = new Dog("Hashbrown", "Mike", 14, Gender.Male);
            x.Bark(8);
            x.GetTag();

            Dog y = new Dog("Joey", "Tom", 1, Gender.Male);
            y.Bark(1);
            y.GetTag();

            Dog z = new Dog("Oreo", "Luke", 6, Gender.Female);
            z.Bark(4);
            z.GetTag();
        }
    

    }
}