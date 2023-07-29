using System;
using static System.Net.Mime.MediaTypeNames;

//ref link:https://www.youtube.com/watch?v=D8eR5kA-vUc&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=3
// ctrl+k+c -- comment line

class MainClass
{
    static void Main()
    {
        int[] ages = new[] { 25, 27, 23, 34, 36 };    
        int totalAge = 0;
        //for (int i = 0; i < ages.Length; i++)
        foreach (int element in ages)
        {
            //Console.WriteLine(ages[i]);
            //totalAge += ages[i];
            Console.WriteLine(element);
            totalAge += element;
        }
        Console.WriteLine(totalAge);
        //ages[5] = 29; // index out of range exception
    }
}