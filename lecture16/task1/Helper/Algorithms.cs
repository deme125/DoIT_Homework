using System;
using System.ComponentModel.DataAnnotations;
namespace task1
{
    internal class Algorithms
    {
        public static IEnumerable<T> Where<T>(IEnumerable<T> collection, Func<T, bool> func)
        {

            foreach (var item in collection)
            {
                if (func(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> OrderBy<T, Tkey>(IEnumerable<T> collection, Func<T, Tkey> func)
            where Tkey : IComparable<Tkey>
        {
            List<T> list = new List<T>(collection);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    Tkey keyA = func(list[i]);
                    Tkey keyB = func(list[j]);

                    if (keyA.CompareTo(keyB) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        public static T First<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            foreach (var item in collection)
            {
                if (func(item))
                {
                    return item;
                }
            }
            throw new InvalidOperationException("No matching element found!");
        }

        public static T FirstOrDefault<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            foreach (var item in collection)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;
        }

        public static T Single<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            int counter = 0;
            T value = default;
            foreach (var item in collection)
            {
                if (func(item))
                {
                    counter++;
                    value = item;

                    if (counter > 1)
                    {
                        throw new InvalidOperationException("This condition has at least one duplicate");
                    }
                }
            }
            if (counter == 1)
            {
                return value;
            }
            throw new InvalidOperationException("No matching element was found.");

        }

        public static T SingleOrDefault<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            int counter = 0;
            T value = default;
            foreach (var item in collection)
            {
                if (func(item))
                {
                    counter++;
                    value = item;

                    if (counter > 1)
                    {
                        throw new InvalidOperationException("This conditions has at least one duplicate");
                    }
                }
            }
            if (counter == 1)
            {
                return value;
            }
            return default;

        }

        public static bool Any<T>(IEnumerable<T> collection, Func<T, bool> func)
        {

            foreach (var item in collection)
            {
                if (func(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All<T>(IEnumerable<T> collection, Func<T, bool> func)
        {

            foreach (var item in collection)
            {
                if (!func(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static int Count<T>(IEnumerable<T> collection, Func<T, bool> func)
        {
            int counter = 0;
            foreach (var item in collection)
            {
                if (func(item))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static IEnumerable<T> Distinct<T>(IEnumerable<T> collection)
        {
            HashSet<T> seenItems = new HashSet<T>();

            foreach (var item in collection)
            {
                if (seenItems.Add(item))
                {
                    yield return item;
                }
            }
        }

    }
}

