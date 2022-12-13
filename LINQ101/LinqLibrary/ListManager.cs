using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ101.LinqLibrary
{
    public class ListManager
    {
        

        public static List<Person> LoadData()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { FirstName = "David", LastName = "Ukpoju", Birthday = Convert.ToDateTime("6/14/1994"), YearsOfExperience = 20 });
            output.Add(new Person { FirstName = "Joe", LastName = "Smith", Birthday = Convert.ToDateTime("3/31/1994"), YearsOfExperience = 12 });
            output.Add(new Person { FirstName = "Sue", LastName = "Storm", Birthday = Convert.ToDateTime("1/3/1994"), YearsOfExperience = 1 });
            output.Add(new Person { FirstName = "Sara", LastName = "Jones", Birthday = Convert.ToDateTime("3/6/1994"), YearsOfExperience = 8 });
            output.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("2/18/1994"), YearsOfExperience = 7 });
            output.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("1/23/1994"), YearsOfExperience = 16 });

            return output;
        }
    }
}
