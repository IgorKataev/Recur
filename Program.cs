// using System;
// class Program { static void PrintNumbers(int m, int n) { if (m <= n) { Console.WriteLine(m); PrintNumbers(m + 1, n); } }
// static void Main()
// {
//     int m = 2;
//     int n = 8;
//     PrintNumbers(m, n);
// }
// }

// class Program { static int Ackermann(int m, int n) { if (m == 0) { return n + 1; } else if (n == 0) { return Ackermann(m - 1, 1); } else { return Ackermann(m - 1, Ackermann(m, n - 1)); } }
// static void Main()
// {
//     int m = 3;
//     int n = 2;
//     int result = Ackermann(m, n);
//     Console.WriteLine($"Ackermann({m}, {n}) = {result}");
// }
// }

using System;
class Program { static void PrintArrayReverse(int[] arr, int index) { if (index >= 0) { Console.WriteLine(arr[index]); PrintArrayReverse(arr, index - 1); } }
static void Main()
{
    int[] array = { 2, 4, 6, 8, 10 };
    PrintArrayReverse(array, array.Length - 1);
}
}