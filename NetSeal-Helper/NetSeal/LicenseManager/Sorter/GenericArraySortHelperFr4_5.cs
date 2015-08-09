//Exported from System.Collections.Generic.GenericArraySortHelper, mscorlib

using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace System.Collections.GenericFr4_5
{
	internal class GenericArraySortHelper<TKey, TValue> : IArraySortHelper<TKey, TValue> where TKey : IComparable<TKey>
	{
		public GenericArraySortHelper()
		{
		}

		private static void DepthLimitedQuickSort(TKey[] keys, TValue[] values, int left, int right, int depthLimit)
		{
			while (depthLimit != 0)
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
				depthLimit--;
				if (num2 - left <= right - num)
				{
					if (left < num2)
					{
						GenericArraySortHelper<TKey, TValue>.DepthLimitedQuickSort(keys, values, left, num2, depthLimit);
					}
					left = num;
				}
				else
				{
					if (num < right)
					{
						GenericArraySortHelper<TKey, TValue>.DepthLimitedQuickSort(keys, values, num, right, depthLimit);
					}
					right = num2;
				}
				if (left >= right)
				{
					return;
				}
			}
			GenericArraySortHelper<TKey, TValue>.Heapsort(keys, values, left, right);
		}

		private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo)
		{
			TKey tKey = keys[lo + i - 1];
			TValue tValue = (values != null) ? values[lo + i - 1] : default(TValue);
			while (i <= n / 2)
			{
				int num = 2 * i;
				if (num < n && (keys[lo + num - 1] == null || keys[lo + num - 1].CompareTo(keys[lo + num]) < 0))
				{
					num++;
				}
				if (keys[lo + num - 1] == null || keys[lo + num - 1].CompareTo(tKey) < 0)
				{
					break;
				}
				keys[lo + i - 1] = keys[lo + num - 1];
				if (values != null)
				{
					values[lo + i - 1] = values[lo + num - 1];
				}
				i = num;
			}
			keys[lo + i - 1] = tKey;
			if (values != null)
			{
				values[lo + i - 1] = tValue;
			}
		}

		private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi)
		{
			int num = hi - lo + 1;
			for (int i = num / 2; i >= 1; i--)
			{
				GenericArraySortHelper<TKey, TValue>.DownHeap(keys, values, i, num, lo);
			}
			for (int j = num; j > 1; j--)
			{
				GenericArraySortHelper<TKey, TValue>.Swap(keys, values, lo, lo + j - 1);
				GenericArraySortHelper<TKey, TValue>.DownHeap(keys, values, 1, j - 1, lo);
			}
		}

		private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi)
		{
			for (int i = lo; i < hi; i++)
			{
				int num = i;
				TKey tKey = keys[i + 1];
				TValue tValue = (values != null) ? values[i + 1] : default(TValue);
				while (num >= lo && (tKey == null || tKey.CompareTo(keys[num]) < 0))
				{
					keys[num + 1] = keys[num];
					if (values != null)
					{
						values[num + 1] = values[num];
					}
					num--;
				}
				keys[num + 1] = tKey;
				if (values != null)
				{
					values[num + 1] = tValue;
				}
			}
		}

		private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit)
		{
			while (hi > lo)
			{
				int num = hi - lo + 1;
				if (num <= 16)
				{
					if (num == 1)
					{
						return;
					}
					if (num == 2)
					{
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, lo, hi);
						return;
					}
					if (num == 3)
					{
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, lo, hi - 1);
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, lo, hi);
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, hi - 1, hi);
						return;
					}
					GenericArraySortHelper<TKey, TValue>.InsertionSort(keys, values, lo, hi);
					return;
				}
				else
				{
					if (depthLimit == 0)
					{
						GenericArraySortHelper<TKey, TValue>.Heapsort(keys, values, lo, hi);
						return;
					}
					depthLimit--;
					int num2 = GenericArraySortHelper<TKey, TValue>.PickPivotAndPartition(keys, values, lo, hi);
					GenericArraySortHelper<TKey, TValue>.IntroSort(keys, values, num2 + 1, hi, depthLimit);
					hi = num2 - 1;
				}
			}
		}

		internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length)
		{
			if (length < 2)
			{
				return;
			}
			GenericArraySortHelper<TKey, TValue>.IntroSort(keys, values, left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2(keys.Length));
		}

		private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi)
		{
			int num = lo + (hi - lo) / 2;
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, lo, num);
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, lo, hi);
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithItems(keys, values, num, hi);
			TKey tKey = keys[num];
			GenericArraySortHelper<TKey, TValue>.Swap(keys, values, num, hi - 1);
			int i = lo;
			int j = hi - 1;
			while (i < j)
			{
				if (tKey == null)
				{
					while (i < hi - 1 && keys[++i] == null)
					{
					}
					while (j > lo)
					{
						if (keys[--j] == null)
						{
							break;
						}
					}
				}
				else
				{
					while (tKey.CompareTo(keys[++i]) > 0)
					{
					}
					while (tKey.CompareTo(keys[--j]) < 0)
					{
					}
				}
				if (i >= j)
				{
					break;
				}
				GenericArraySortHelper<TKey, TValue>.Swap(keys, values, i, j);
			}
			GenericArraySortHelper<TKey, TValue>.Swap(keys, values, i, hi - 1);
			return i;
		}

		public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
        {
        //    try
        //    {
        //        if (comparer == null || comparer == Comparer<TKey>.Default)
        //        {
        //            if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
        //            {
        //                GenericArraySortHelper<TKey, TValue>.IntrospectiveSort(keys, values, index, length);
        //            }
        //            else
        //            {
        //                GenericArraySortHelper<TKey, TValue>.DepthLimitedQuickSort(keys, values, index, length + index - 1, 32);
        //            }
        //        }
        //        else if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
        //        {
        //            ArraySortHelper<TKey, TValue>.IntrospectiveSort(keys, values, index, length, comparer);
        //        }
        //        else
        //        {
        //            ArraySortHelper<TKey, TValue>.DepthLimitedQuickSort(keys, values, index, length + index - 1, comparer, 32);
        //        }
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(comparer);
        //    }
        //    catch (Exception innerException)
        //    {
        //        throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_IComparerFailed"), innerException);
        //    }
		}

		private static void Swap(TKey[] keys, TValue[] values, int i, int j)
		{
			if (i != j)
			{
				TKey tKey = keys[i];
				keys[i] = keys[j];
				keys[j] = tKey;
				if (values != null)
				{
					TValue tValue = values[i];
					values[i] = values[j];
					values[j] = tValue;
				}
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
