//Exported from System.Collections.Generic.GenericArraySortHelper, mscorlib

using System;
using System.Runtime.Versioning;

namespace System.Collections.Generic
{
	internal static class IntrospectiveSortUtilities
	{
		internal const int IntrosortSizeThreshold = 16;

		internal const int QuickSortDepthThreshold = 32;

		internal static int FloorLog2(int n)
		{
			int num = 0;
			while (n >= 1)
			{
				num++;
				n /= 2;
			}
			return num;
		}		
	}
}
