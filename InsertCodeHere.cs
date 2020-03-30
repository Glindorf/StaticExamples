using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Car CarA = new Car("Bil1", 123456);
            Car CarB = new Car("Bil2", 123556);
            Car CarC = new Car("Bil3", 143456);

            CarB.LicensePlate = "blablabla";
            System.Console.WriteLine(CarB.LicensePlate);

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };

            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}"); 
            #endregion

            Car.PrintUsageStatistics();

            // The LAST line of code should be ABOVE this line
        }
    }
}