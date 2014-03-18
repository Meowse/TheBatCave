using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckForDuplicates
{
    public class DuplicateChecker
    {
        public bool HasDuplicates(List<int> someList)
        {
//            // For each element in the list, check whether it is the same as
//            // any of the elements after it.
//            for (int i = 0; i < someList.Count; i++)
//            {
//                int element = someList[i];
//                for (int j = i + 1; j < someList.Count; j++)
//                {
//                    if (element == someList[j])
//                    {
//                        return true;
//                    }
//                }
//            }
//            return false;
            // Sort the list, and then go through and compare each pair of
            // adjacent elements, looking for duplicates.
            //someList.Sort();

            // For each element in the list, check if it's in the Set already,
            // and if not, add it to the Set.
//            ISet<int> set = new HashSet<int>();
////          for (int i = 0; i < someList.Count; i++)
////          {
////              int someValue = someList[i];
//            foreach (int someValue in someList)
//            {
//                if (set.Contains(someValue))
//                {
//                    return true;
//                }
//                set.Add(someValue);
//            }
//            return false;

            ISet<int> set = new HashSet<int>(someList);
            return set.Count != someList.Count;
        }

        // TODO: Write "CountDuplicates"
        // Example: given { 1, 1, 2, 2, 2, 3, 4, 5 }, return 5, since 5 of
        // the values are "duplicates"

        public int CountDuplicates(List<int> values)
        {
            ISet<int> uniqueValues = new HashSet<int>();
            foreach (int value in values)
            {
                if (values.Contains(value))
                {
                    uniqueValues.Add(value);
                }
            }
            return uniqueValues.Count;
        }

        // TODO: Write "ReturnDistinctCountOfDuplicates"
        // Example: given { 1, 1, 2, 2, 2, 3, 4, 5 }, return 2, since there
        // are two values of which there are duplicates

        public int ReturnDistinctCountOfDuplicates(List<int> values)
        {
            ISet<int> uniqueValues = new HashSet<int>();
            ISet<int> duplicates = new HashSet<int>();
            foreach (int value in values)
            {
                if (uniqueValues.Contains(value) && !duplicates.Contains(value))
                {
                    duplicates.Add(value);
                }
                uniqueValues.Add(value);
            }
            return duplicates.Count;
        }

    // TODO: Write "GetDuplicateCounts" which returns a Dictionary<int, int>() 
        // containing the number of duplications of each value that is duplicated.
        // Example: given { 1, 1, 2, 2, 2, 2, 3, 4, 5, 5 }, it would return 
        // a map with keys 1, 2, and 5, and corresponding values 2, 4, and 2,
        // i.e. a map with (key, value) pairs: (1, 2), (2, 4), (5, 2).
        public Dictionary<int, int> GetDuplicateCounts(List<int> values)
        {
            var duplicateCounts = new Dictionary<int, int>();
            foreach (var value in values)
            {
                if (!duplicateCounts.ContainsKey(value))
                {
                    duplicateCounts[value] = 1;
                    //duplicateCounts.Add(value, 1); also works
                }
                else
                {
                    duplicateCounts[value]++;
                }
            }
            return duplicateCounts;
        }
    }
}
