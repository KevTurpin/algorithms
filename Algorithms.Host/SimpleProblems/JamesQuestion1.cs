using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Host.SimpleProblems
{
    public static class JamesQuestion1
    {
        public static IEnumerable<int> UseTheLanguageALittle(int[] listA, int[] listB)
        {
            foreach (var item in listA)
            {
                if (!listB.Contains(item)) continue;
                yield return item;
            }
        }

        public static IEnumerable<int> UseTheLanguageMore(int[] listA, int[] listB) 
            => listA.Where(listB.Contains);

        public static IEnumerable<int> UseMinimumLanguageFeatures(int[] listA, int[] listB)
        {
            foreach (var itemA in listA)
            {
                foreach (var itemB in listB)
                {
                    if (!itemB.Equals(itemA)) continue;
                    yield return itemB;
                }
            }
        }
    }
}