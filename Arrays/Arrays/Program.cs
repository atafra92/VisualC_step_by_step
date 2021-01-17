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
            ref var youngest = ref person.FindYoungest(family); //a reference to item in family array

            Console.WriteLine($"Ime najmladeg clana obitelji: {youngest._ime}, godine: {youngest._godine}");          
            youngest._godine++; //now it updates youngest's age

            Console.WriteLine("Svi clanovi obitelji...");
            foreach (var familyMember in family)
            {
                Console.WriteLine($"Ime: {familyMember._ime}, godine: {familyMember._godine }");
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// structs are value types 
    /// Structs are declared same way as classes, except they not accept default constructors
    /// initialization(implicitly constructed by default)
    /// </summary>
    public struct Person
    {
        public string _ime;
        public int _godine;


        public Person(string ime, int godine)
        {
            _ime = ime;
            _godine = godine;
        }

        /// <summary>
        /// Return type of a method changes to ref Person(a reference to a Person) and 
        /// return statement states it passes back a reference to the youngest item in family array
        /// </summary>
         public ref Person FindYoungest(Person[] family)
         {
            int youngest = 0;

            for (int i = 1; i < family.Length; i++)
            {
                if (family[i]._godine < family[youngest]._godine)
                {
                    youngest = i;
                }
            }

            return ref family[youngest];  
         }

    }
}
