using System;
using System.Collections.Generic;

namespace PlayingWithRandom
{
    class Program
    {
        static void Main(string[] args)
        {


            //Random random = new Random(1); // dont do this beacuse the random numbers will be the same everytime you run the program;
            Random random = new Random(); // typically only need to instantiate this once per app unless you are using async methods or non thread safe methods?

            List<int> randomList = new List<int>();

            for (var i = 0; i < 10; i++)
            {

                int currentNum = random.Next(1, 51);
                randomList.Add(currentNum);
                Console.WriteLine(currentNum);

            }




            Console.WriteLine("\n\n");

            Console.WriteLine($"\n\n Willies Second Random Number From The Single Instantiation\n\n " +
                $"Random #2: {random.Next(200, 1000)}\n\n");







            int sum = 0;

            foreach (int num in randomList)
            {
                sum += num;
                Console.WriteLine(sum);

            }
            Console.WriteLine("\n\n final sum");
            Console.WriteLine(sum);





            //int[] add_arr = randomList.ToArray();   // this works but there has to be an easier way to add values to an array


            //Console.WriteLine($"\n\n Array Valus: ");
            //for (var i = 0; i < add_arr.Length; i++)
            //{
            //     Console.WriteLine($"{ add_arr[i] }");
            //}



            Console.WriteLine("\n\n");

            //string[] monthsArr = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            //string[] monthsArr = new string[12];

            //List<string> theMonths = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //monthsArr = new[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            //foreach(var month in monthsArr)
            //{
            //    Console.WriteLine(month);
            //}

            FindInDictionary("K");
            FindInDictionary2("Ca");

            Console.ReadLine();
        }

        public class Element
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public int AtomicNumber { get; set; }
        }

        private static Dictionary<string, Element> BuildDictionary()
        {
            return new Dictionary<string, Element>
            {
                {"K",
                    new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
                {"Ca",
                    new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
                {"Sc",
                    new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
                {"Ti",
                    new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
            };
        }


        private static void FindInDictionary(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();

            if (elements.ContainsKey(symbol) == false)
            {
                Console.WriteLine(symbol + " not found");
            }
            else
            {
                Element theElement = elements[symbol];
                Console.WriteLine("found: " + theElement.Name); 
            }
        }


        private static void FindInDictionary2(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();

            Element theElement = null;
            if (elements.TryGetValue(symbol, out theElement) == false)
                Console.WriteLine(symbol + " not found");
            else
                Console.WriteLine("found: " + theElement.Name);
        }

    }
}
