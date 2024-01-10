internal class Program {
    private static void Main(string[] args) {
            Console.WriteLine("Area Calculator");
            double sideA;
            double sideB;

            Console.WriteLine("Type a width for the rectangle in cm");
            sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type a height for the rectangle in cm");
            sideB = Convert.ToDouble(Console.ReadLine());

        var result = sideA * sideB;
        Console.WriteLine("The area for this rectangle equals:" + result);
    }
}