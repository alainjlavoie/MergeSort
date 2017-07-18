using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class RandomNumber
    {
        public List<int> GenerateRandomNumber(int min, int max)
        {
            var randomObj = new Random();
            var rtnlist = new List<int>();

            for (int i = min; i < 200; i++)
            {
                rtnlist.Add(randomObj.Next(max));
            }

            return rtnlist;
        }
    }
}
