using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierProblem
{
    public static class DateModifier
    {
        public static int GetDiffBetweenDates(string dateOne, string dateTwo)
        {
            DateTime date1 = DateTime.Parse(dateOne);
            DateTime date2 = DateTime.Parse(dateTwo);

            TimeSpan difference = date1 - date2;

            return difference.Days;
        }
    }
}
