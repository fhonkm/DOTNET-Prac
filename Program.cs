using System.Runtime.InteropServices;

namespace HelloWorld;

class Program
{
    static readonly int WindowWidth = Console.WindowWidth;
    static readonly string[] ArrayTest = ["Test1", "Test2", "Test3"];
    static void Main(string[] args)
    {
        Hello("Hello");

        for (int i = 0; i < ArrayTest.Length; i++) {
            Console.WriteLine(ArrayTest[i]);
        }
    }

    public static void Hello(string message) {
        Console.WriteLine($"{message} {WindowWidth}");
    }
}
