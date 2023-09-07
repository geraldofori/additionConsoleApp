using System;
using System.Runtime.InteropServices;

class Program {
    [DllImport("libadd.so")]
    public static extern int add(int a, int b);

    static void Main() {
        int result = add(8, 8);
        Console.WriteLine($"Result: {result}");
    }
}
