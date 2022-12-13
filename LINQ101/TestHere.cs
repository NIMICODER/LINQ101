using LINQ101.LinqLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQInCsharp.Datastore;

namespace LINQ101
{
    internal class TestOperatorHere
    {
      static  List<Person> people = ListManager.LoadData();

        public static void UsingOrderBy()
        {
            //OrderBy=>Ascending,Descending, (ToOrderBy more than one thing=Add .ThenBy or .ThenByDescending follow by the anonymous method to). 
            people = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsOfExperience).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}), Experience: {person.YearsOfExperience} years ");
                //Console.WriteLine(person);
            }
            Console.ReadLine();
        }

       
        //Aggregation Operator
        public static void UsingSum()
        {
            //int yearsTotal = people.Sum(x => x.YearsOfExperience);
            int yearsTotal = 0;
            //people.Sum(x => x.YearsOfExperience);
            yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsOfExperience);

            Console.WriteLine($"The total years of Experience is: {yearsTotal}");

            Console.ReadLine();
        }
        public static void UsingCount()
        {
            //var count = 0;
            var result = people.Count(x => x.YearsOfExperience <= 5);

            Console.WriteLine(result);
        }

        public static void UsingMaxBy()
        {
            var result = people.MaxBy(x => x.YearsOfExperience);
            Console.WriteLine($"Highest year of experience:{result.FirstName}, {result.YearsOfExperience}");
        }

        //Projection Operator
        public static void UsingWhere()
        {
            people = people.Where(x => x.YearsOfExperience > 10 && x.Birthday.Month == 3).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}), Experience: {person.YearsOfExperience} years ");
                //Console.WriteLine(person);
            }
            Console.ReadLine();
        }


        public static void UsingOfTypeMethodSyntax()
        {
            ArrayList arrayList = new ArrayList()
            {
                1, 2,"Alex", true, 3,5, "Alexa"
            };

            var result = arrayList.OfType<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }


        public static void UsingIsQuerySyntax()
        {
            List<object> people = new List<object>()
            {
                1,2,"David", true, 3, 5
            };

            var result = from item in people
                         where item is string
                         select item;
            foreach (var person in result)
            {
                Console.WriteLine(person);
            }
        }

        public static void UsingWhereMethod()
        {
            var result = Formula1.GetChampions()
                .Where(x => x.Country.Contains("Austria"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void UsingSelect()
        {
            var racers = Formula1.GetChampions();
            var result = racers.Where(x => x.FirstName.StartsWith('J'));
            
            foreach (var rac in result)
            {
                Console.WriteLine(rac);
            }
        }

        public static void UsingSelectB()
        {
            var people = ListManager.LoadData();
            var result = people.Where(x => x.FirstName.StartsWith('J'));

            foreach (var person in result)
            {
                Console.WriteLine(person.FirstName);
            }
        }

        public static void UsingSelectMany()
        {
            var racer = Formula1.GetChampions();
            var result = racer.SelectMany(x => x.Years);  

            foreach (var person in result)
            {
                Console.WriteLine($"Year of Cars: {person}");
            }
        }

       

        
        public static void UsingWhereMethodB()
        {
            var result = ListManager.LoadData().Where(x => x.FirstName.Contains("Jamie"));
            
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //partitioning operators

        public static void UsingTakeMethod()
        {
            var takeSample1 = Formula1.GetChampions().Take(2);
            
            foreach (var item in takeSample1)
            {
                Console.WriteLine($"Country: {item.Country}, LastName: {item.LastName}");
            }
        }

        public static void UsingTakeMethodB()
        {
            var takeSample1 = ListManager.LoadData().Take(2);

            foreach (var item in takeSample1)
            {
                Console.WriteLine($"YearsOfExperience: {item.YearsOfExperience}, LastName: {item.LastName}");
            }
        }

        //SkipPatitioning operators

        public static void UsingSkip()
        {
            var takeSample1 = Formula1.GetChampions().Skip(2);

            foreach (var item in takeSample1)
            {
                Console.WriteLine($"Country: {item.Country}, LastName: {item.LastName}");
            }
        }

        public static void UsingSkipB()
        {
            var takeSample1 = ListManager.LoadData().Skip(2);

            foreach (var item in takeSample1)
            {
                Console.WriteLine($"YearsOfExperience: {item.YearsOfExperience}, LastName: {item.LastName}");
            }
        }

        public static void UsingSkipWhile()
        {
            var takeSample1 = ListManager.LoadData()
                .SkipWhile( x => x.YearsOfExperience >= 5 || x.LastName.StartsWith('U'));

            foreach(var item in takeSample1)
            {
                Console.WriteLine($"YearsOfExperience: {item.YearsOfExperience}, LastName: {item.LastName}");
            }
        }

        //Merging Operators
        public static void UsingJoin()
        {
            
            var sequence1 = new List<int> { 1, 3, 5 };
            var sequence2 = new List<int> { 2, 4, 6 };

            // Use the Merge operator to combine the sequences
            var merged = sequence1.Join(sequence2, b =>  (a, b) => a + b); 

            // Print the resulting sequence
            foreach (var item in merged)
            {
                Console.WriteLine(item);
            }

        }

    }
}
