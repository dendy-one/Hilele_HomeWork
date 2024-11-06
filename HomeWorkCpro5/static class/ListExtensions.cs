using System;
using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{
    public static IEnumerable<int> Filter(this List<int> numbers, Func<int, bool> filterCondition)
    {
        return numbers.Where(filterCondition);
    }
}
