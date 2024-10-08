using System;

namespace c_
 {
    internal class Program
    {
        static void Main(string[] args)
        {
            string nightOwl = "Night Owl";
            Console.WriteLine(nightOwl);
            
            int x = 75;

            double y = 3;
            Console.WriteLine(x + y);

            char m = 'M';
            Console.WriteLine(m);

            int[] myIntArray = {1, 2, 3, 4, 5};

            for(int i = 0; i < myIntArray.Length; i++) 
            {
                Console.WriteLine(myIntArray[i]);
            }
            
            Console.WriteLine("\n");

            string[] myStringArray = {"Cheesecake", "Cupcake", "Bundt Cake", "Mug Cake"};
            
            foreach(string myString in myStringArray)
            {
            Console.WriteLine(myString);
            }  

            Console.WriteLine("\n");

            List<string> stringList = new List<string> ();
            stringList.Add("Crepe Cake"); 
            stringList.Add("Chiffon Cake"); 
            stringList.Add("Coffee Cake");

            foreach(string strings in stringList)
            {
                Console.WriteLine(strings);
            }
        }
   }
 }