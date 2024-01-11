internal class Program {
    public static bool play = true;
    private static void Main(string[] args) {
        var result = 0d;
    
        do {
            Console.WriteLine("MENU\nEscriba una opcion\nRect\nCirc\nLogic\nStr");
            string option = Console.ReadLine().ToUpper();
            switch (option) {
                case "RECT": {
                        Console.WriteLine("Area Calculator");
                        double sideA;
                        double sideB;

                        Console.WriteLine("Type a width for the rectangle in cm");
                        sideA = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Type a height for the rectangle in cm");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        const double OneInch = 2.54;
                        result = sideA * sideB * OneInch;
                        string unit = "in²";
                        Console.WriteLine("The area for this rectangle equals:" + result + unit);
                        break;
                    }
                case "CIRC": {

                        Console.WriteLine("Now let's calculate circles.");
                        Console.WriteLine("Type the radius value");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        const double Pi = 3.1416925;
                        result = Math.Pow(2, radio) * Pi;
                        Console.WriteLine("The circle area is: " + result);
                        Console.WriteLine(result);
                        break;
                    }
                case "LOGIC": {
                        //Operadores lógicos

                        var (hasAccount, password, twoFA) = (true, false, true);

                        bool and = hasAccount && password; //True if both are true.
                        bool or = twoFA || password; //True if one is true
                        bool not = !password; //Opposite
                        bool xor = hasAccount ^ twoFA; //False if equal

                        Console.Write(and);
                        Console.Write(or);
                        Console.Write(not);
                        Console.Write(xor);
                        break;
                    }
                case "STR": {
                        //Strings
                        uint height = 178;
                        string name = "Hernando";
                        string profession = "Cook";
                        string hobbie = "Music";

                        string identification = $"La info es la siguiente: \nAltura: {height} \n Name: {name.ToUpper()}\nProfession: {profession}\nHobbie: {hobbie}";
                        Console.WriteLine(identification);
                        break;
                    }
                case "EXIT": { Program.play = false; if (!Program.play) { Console.WriteLine("Stopping..."); } break; }
                default: {
                        Console.WriteLine("WTF are you doing");
                        Console.Clear();
                        Program.Main(args);
                        break;
                    }
            }
        } while (play);
    }
}