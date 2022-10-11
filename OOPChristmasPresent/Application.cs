using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChristmasPresent
{
    internal class Application
    {


        public void Run()
        {
            var person1 = new Person("Christoffer");
            var person2 = new Person("Filippa");

            person1.AddPresent(new ChristmasPresent("Processor i9", 4800));
            person1.AddPresent(new ChristmasPresent("SSD disk", 480));
            person2.AddPresent(new ChristmasPresent("Kaka", 300));


            var personer = new List<Person>();
            personer.Add(person1);
            personer.Add(person2);

            foreach (var person in personer)
            {
                Console.WriteLine($"{person.Name} ska få julklappar för {person.GetTotalPrice()}");
            }

            



        }

        
    }
}
