﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonExecutor.Framework.Unit.Tests.TestTypes
{
    public static class Math
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int AddWithArray(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }
    }
}
