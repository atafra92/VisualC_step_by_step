using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] family = new[]
            {
                new Person("Antonio", 28),
                new Person("Antonija", 32),
                new Person("Grgo", 60),
                new Person("Marija", 50)
            };

            Person person = new Person();
            var youngest = person.FindYoungest(family);

            Console.WriteLine($"Ime najmladeg clana obitelji: {youngest._ime}, godine: {youngest._godine}");          
            youngest._godine++; //incremnts youngest age by one(if using struct instead of class this won't work)

            Console.WriteLine("Svi clanovi obitelji...");
            foreach (var familyMember in family)
            {
                Console.WriteLine($"Ime: {familyMember._ime}, godine: {familyMember._godine }");
            }

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string _ime;
        public int _godine;

        public Person()
        {

        }
        public Person(string ime, int godine)
        {
            _ime = ime;
            _godine = godine;
        }

        public Person FindYoungest(Person[] family)
        {
            int youngest = 0;

            for (int i = 1; i < family.Length; i++)
            {
                if (family[i]._godine < family[youngest]._godine)
                {
                    youngest = i;
                }
            }
            var result = family[youngest];
            return result;
        }

    }
}
