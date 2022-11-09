using System;
using System.IO;

namespace DivideAndConquer
{
    public class ReadFile
    {
        public static int[] listNumSorted()
        {
            StreamReader reader = new StreamReader("file.txt");
            string[] arr = reader.ReadToEnd().Split(';');
            int[] arrInt = Array.ConvertAll(arr, z => int.Parse(z));
            Array.Sort(arrInt);
            return arrInt;
        }
        
    }
}