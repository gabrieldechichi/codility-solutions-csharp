﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityRuntime.Core
{
    class CodilityRuntimeUtils
    {
        public static Func<IEnumerable<object>, IEnumerable<object>> GetSolutionFunc<T1, TRet>(Func<T1, TRet> func)
        {
            return (input) =>
            {
                T1 typedInput = (T1)Convert.ChangeType(input.ElementAt(0), typeof(T1));
                return new List<object>() { func(typedInput) };
            };
        }

        public static Func<IEnumerable<object>, IEnumerable<object>> GetSolutionFunc<T1, T2, TRet>(Func<T1, T2, TRet> func)
        {
            return (input) =>
            {
                T1 typedInput1 = (T1)Convert.ChangeType(input.ElementAt(0), typeof(T1));
                T2 typedInput2 = (T2)Convert.ChangeType(input.ElementAt(1), typeof(T2));
                return new List<object>() { func(typedInput1, typedInput2) };
            };
        }

        public static Func<IEnumerable<object>, IEnumerable<object>> GetSolutionFunc<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> func)
        {
            return (input) =>
            {
                T1 typedInput1 = (T1)Convert.ChangeType(input.ElementAt(0), typeof(T1));
                T2 typedInput2 = (T2)Convert.ChangeType(input.ElementAt(1), typeof(T2));
                T3 typedInput3 = (T3)Convert.ChangeType(input.ElementAt(2), typeof(T3));
                return new List<object>() { func(typedInput1, typedInput2, typedInput3) };
            };
        }
    }
}
