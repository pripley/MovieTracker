﻿using System;

namespace MovieTracker.Data
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Computes the distance between two strings.
        /// </summary>
        //    public static List<string> OrderBySimilarity(this string String, List<string>)
        //    {
        //        int n = s.Length;
        //        int m = t.Length;
        //        int[,] d = new int[n + 1, m + 1];

        //        // Step 1
        //        if (n == 0)
        //        {
        //            return m;
        //        }

        //        if (m == 0)
        //        {
        //            return n;
        //        }

        //        // Step 2
        //        for (int i = 0; i <= n; d[i, 0] = i++)
        //        {
        //        }

        //        for (int j = 0; j <= m; d[0, j] = j++)
        //        {
        //        }

        //        // Step 3
        //        for (int i = 1; i <= n; i++)
        //        {
        //            //Step 4
        //            for (int j = 1; j <= m; j++)
        //            {
        //                // Step 5
        //                int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

        //                // Step 6
        //                d[i, j] = Math.Min(
        //                    Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
        //                    d[i - 1, j - 1] + cost);
        //            }
        //        }
        //        // Step 7
        //        return d[n, m];
        //    }
        //}

        /// <summary>
        /// Returns the date of the next day of the week specified
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="Day"></param>
        /// <returns></returns>
        public static DateTime NextDayOfWeek(this DateTime Date, DayOfWeek Day)
        {
            int daysToAdd = ((int)Day - (int)Date.DayOfWeek + 7) % 7;
            return Date.AddDays(daysToAdd);
        }

        public static string SortString(this String Title)
        {
            string sortString = null;

            if (!String.IsNullOrEmpty(Title))
            {
                string modTitle = Title.Trim().ToUpperInvariant();
                modTitle = modTitle.Replace(":", null);
                modTitle = modTitle.Replace(",", null);
                string[] titleElems = modTitle.Split(new string[] { "THE ", "A ", "AN " }, 2, StringSplitOptions.None);
                modTitle = titleElems.Length > 1 && titleElems[0].Length <= 4 ? titleElems[1] : titleElems[0];
                string[] sortWords = modTitle.Split(new char[] { ' ' });

                for (int index = 0; index < sortWords.Length && index < 4; index++)
                {
                    sortString += sortWords[index].Substring(0, Math.Min(5 - index, sortWords[index].Length));
                }
            }

            return sortString;
        }
    }
}