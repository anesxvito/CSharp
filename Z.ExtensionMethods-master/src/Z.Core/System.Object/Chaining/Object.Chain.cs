public class Example
{
    public int Value { get; set; }

    public static void Main()
    {
        var example = new Example { Value = 10 };

        example.Chain(e => e.Value += 5)   // Increment Value by 5
               .Chain(e => Console.WriteLine(e.Value))  // Print Value
               .Chain(e => e.Value *= 2);  // Double Value

        // Output:
        // 15
    }
}
