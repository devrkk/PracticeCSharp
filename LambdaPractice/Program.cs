namespace LambdaPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 1.基本的なラムダ式
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5)); // 出力: 25

            Func<bool, bool> boolTest = x => x;
            Console.WriteLine(boolTest(true)); // 出力: True

            Func<string, string> greet = name => $"Hello, {name}!";
            Console.WriteLine(greet("Alice")); // 出力: Hello, Alice!

            Func<byte, byte> byteTest = x => (byte)(x + 1);
            Console.WriteLine(byteTest(10));

            var text = "";
            var lst = new List<int>
            { 1, 3, 5 };
            lst.ForEach(x => text += $"{x * x},");
            Console.WriteLine(text);

            // ラムダ式の例をいくつか追加します。

            // 2.複数の引数を持つラムダ式
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(3, 4)); // 出力: 7

            // 3.条件付きのラムダ式
        }
    }
}
