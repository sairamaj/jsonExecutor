﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonExecutor.Framework.Unit.Tests.TestTypes
{
    public class Person
    {
        [JsonConstructor]
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

    }
    public static class Sample
    {
        public static IDictionary<string,object> GetInfo()
        {
            return new Dictionary<string, object>
            {
                {"result", 0 },
                {"val1", "val1" },
                {"val2", true},
                {"val3", 1.0 }
            };
        }

        public static IDictionary<string, object> GetInfoReturnArrayInDictionary()
        {
            return new Dictionary<string, object>
            {
                {"val1", new string[]{"item1_1","item1_2"} },
                {"val2", new string[]{"item2_1","item2_2"} },
            };
        }

        public static int GetGuidLength(Guid val)
        {
            return val.ToString().Length;
        }

        public static string ProcessPersons(Guid id, IEnumerable<Person> persons)
        {
            var ret = string.Empty;
            foreach (var p in persons)
            {
                ret += $"{p.Name}-{p.Age}-";
            }

            return ret.TrimEnd('-');
        }

        public static IEnumerable<Person> GetPersons(Guid id)
        {
            return new Person[]
            {
                new Person("person1", 10),
                new Person("person2", 20),
            };
        }

        public static IEnumerable<Person> GetNullPersons(Guid id)
        {
            return null;
        }

        public static void GenerateException()
        {
            throw new ArgumentNullException($"this is simulated exception");
        }

        public static string GetRandomString()
        {
            return new Random().Next(Int32.MaxValue).ToString();
        }


        public static void DisplayString(string input)
        {
            Console.WriteLine($"Input is:{input}");
        }

        public static string MethodTakingDictionary(IDictionary<string, string> inputs)
        {
            var output = string.Empty;
            foreach (var kv in inputs)
            {
                output += $"{kv.Key}={kv.Value} ";
            }

            return output.TrimEnd();
        }
    }
}
