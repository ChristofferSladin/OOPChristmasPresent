using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChristmasPresent
{
    public class Person
    {
        private string name;
        private List<ChristmasPresent> presentsList;

        public void AddPresent(ChristmasPresent present)
        {
            presentsList.Add(present);
        }
        public int GetTotalPrice()
        {
            int sum = 0;

            foreach (var present in presentsList)
            {
                sum += present.Price;
            }
            return sum;
        }
        public string Name
        {
            get { return name; }
        }
        public Person(string name)
        {
            this.name = name;
            this.presentsList = new List<ChristmasPresent>();
        }
    }
}
