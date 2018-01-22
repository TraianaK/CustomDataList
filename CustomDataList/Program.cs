using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataList
{
    class Program
    {
        static void Main()
        {
            Zoo zoo = new Zoo(5, new List<string>{ "dog","cat","snake","giraffe"});
            zoo.AddFrog("frog");

            Console.WriteLine("Our zoo consists of {0} animals : " , zoo.Lenght());
            foreach (var animal in zoo.animals)
            {
                Console.WriteLine(animal);
            }
            
            
            Console.WriteLine("The first animal is : {0}.",zoo.First());
            Console.WriteLine("The last animal in the zoo is : {0}.",zoo.Last());
            Console.ReadLine();

            zoo.RemoveFirst(zoo.First());
            zoo.RemoveLast(zoo.Last());
            
            Console.WriteLine("When removing the first and last animal, the zoo changes to : ");

            foreach (var animal in zoo.animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("When removing certain animal the list changes to : ");
            zoo.RemoveByIndex(2);
            foreach (var animal in zoo.animals)
            {
                Console.WriteLine(animal);
            }

            zoo.GetByIndex(2);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("When adding new animals : ");
            zoo.AddFrog("pig");
            zoo.AddFrog("buffalo");
            foreach (var animal in zoo.animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("When sorting : ");
            zoo.Sorting();

            foreach (var animal in zoo.animals)
            {
                Console.WriteLine(animal);
            }



        }
    }
}

