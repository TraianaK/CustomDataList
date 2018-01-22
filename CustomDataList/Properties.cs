using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataList
{
    public class Zoo
    {
        public List<string> animals = new List<string>();
        
        public Zoo(int length, List<string> animals)
        {
            this.length = length;
            this.animals = animals;
        }

        public void AddFrog(string frog) // to add a frog to the zoo
        {
            animals.Add(frog);
            last = frog;
        }

        private int length;
        

        public int Lenght() // count animals
        {
            length = animals.Count();
            return length;
        }

        private string first;

        public string First() //first animal in the zoo 
        {
            return first = animals.First();
        }
        private string last;
        
        public string Last() //last animal in the zoo
        {
            return last = animals.Last();
        }

        public void RemoveFirst(string first)
        {
            animals.Remove(first);
        }

        public void RemoveLast(string last)
        {
            animals.Remove(last);
        }

        private int index;
        public void RemoveByIndex(int index)
        {
            index = 0;
            index++;
            animals.RemoveAt(index);
        }

        public void GetByIndex(int index)
        {
            index = 0;
            index++;
            animals.ElementAt(index);
        }

        public void Sorting()
        {
            animals.Sort();
        }
    }
}
