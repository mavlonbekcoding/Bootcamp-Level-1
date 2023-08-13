using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> listA = new List<int> { 1, 2, 3, 4, 5 };
        List<int> listB = new List<int> { 3, 4, 5, 6, 7 };

        var result = listA.Except(listB).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
