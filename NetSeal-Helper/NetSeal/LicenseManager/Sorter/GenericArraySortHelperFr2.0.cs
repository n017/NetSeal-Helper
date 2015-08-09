//Exported from System.Collections.Generic.GenericArraySortHelper, mscorlib

using System;
using System.Collections.Generic;

namespace System.Collections.GenericFr2_0
{
    public class GenericArraySortHelper<TKey, TValue> : IArraySortHelper<TKey, TValue> where TKey : IComparable<TKey>
    {
        public GenericArraySortHelper()
        {
        }

        public static void QuickSort(TKey[] keys, TValue[] values, int left, int right)
        {
            do
            {
                int num = left;
                int num2 = right;
                int num3 = num + (num2 - num >> 1);
                GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, num, num3);
                GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, num, num2);
                GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, num3, num2);
                TKey tKey = keys[num3];
                do
                {
                    if (tKey == null)
                    {
                        while (keys[num2] != null)
                        {
                            num2--;
                        }
                    }
                    else
                    {
                        while (tKey.CompareTo(keys[num]) > 0)
                        {
                            num++;
                        }
                        while (tKey.CompareTo(keys[num2]) < 0)
                        {
                            num2--;
                        }
                    }
                    if (num > num2)
                    {
                        break;
                    }
                    if (num < num2)
                    {
                        TKey tKey2 = keys[num];
                        keys[num] = keys[num2];
                        keys[num2] = tKey2;
                        if (values != null)
                        {
                            TValue tValue = values[num];
                            values[num] = values[num2];
                            values[num2] = tValue;
                        }
                    }
                    num++;
                    num2--;
                }
                while (num <= num2);
                if (num2 - left <= right - num)
                {
                    if (left < num2)
                    {
                        GenericArraySortHelper<TKey, TValue>.QuickSort(keys, values, left, num2);
                    }
                    left = num;
                }
                else
                {
                    if (num < right)
                    {
                        GenericArraySortHelper<TKey, TValue>.QuickSort(keys, values, num, right);
                    }
                    right = num2;
                }
            }
            while (left < right);
        }

        public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
        {
            if (comparer == null || comparer == Comparer<TKey>.Default)
            {
                GenericArraySortHelper<TKey, TValue>.QuickSort(keys, values, index, index + length - 1);
            }

        }

        private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, int a, int b)
        {
            if (a != b && keys[a] != null && keys[a].CompareTo(keys[b]) > 0)
            {
                TKey tKey = keys[a];
                keys[a] = keys[b];
                keys[b] = tKey;
                if (values != null)
                {
                    TValue tValue = values[a];
                    values[a] = values[b];
                    values[b] = tValue;
                }
            }
        }
    }

    internal interface IArraySortHelper<TKey, TValue>
    {
        void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer);
    }

}
