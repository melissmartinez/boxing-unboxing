using System;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
        //Create an empty List of type object
            list<object> newObject = new List<object>();
        //add the following values to the list: 7, 28, -1, true, "chair"
            newObject.Add(7);
            newObject.Add(28);
            newObject.Add(-1);
            newObject.Add(true);
            newObject.Add("chair");
        // Loop through the list and print all values (Hint: Type Inference might help here!)
        // Add all values that are Int type together and output the sum
            int sum = 0;
            for (int i = 0; i < newObject.Count; i++)
            {
                if (newObject[i] is int) 
                {
                    Console.WriteLine($"This is an integer: {newObject[i]}");
                    int ActualInt = (int)newObject[i];
                    sum += ActualInt;
                }
                else if (newObject[i] is string) 
                {
                    Console.WriteLine($"This is an string: {newObject[i]}");
                }
                else if (newObject[i] is bool)
                {
                    Console.WriteLine($"This is an boolean: {newObject[i]}");
                }
            }
            Console.WriteLine($"The sum of the integers is {sum}.");
        }
    }
}
