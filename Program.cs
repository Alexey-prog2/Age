using System;
 
namespace HelloApp
{ 
    struct User
    {
        public int age;
 
        public void DisplayInfo()
        {
            Console.WriteLine($"Age: {age}");
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            User tom;
            tom.age = 34;
            tom.DisplayInfo();
             
            Console.ReadKey();
        }
    }
}