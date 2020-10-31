using System;
using System.Collections.Generic;
using System.Text;

namespace Cage.Classes
{
    class Cage <T>
    {

        private List<T> animalsInCage;

        public Cage()
        {
            this.animalsInCage = new List<T>();
        }

        public void AddAnimale(T animal)
        {
            this.animalsInCage.Add(animal);
        }

        public void RemoveAnimal (T animal)
        {
            this.animalsInCage.Remove(animal);
        }

        

    }
}
