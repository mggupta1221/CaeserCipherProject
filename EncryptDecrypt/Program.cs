using CaeserCipherAlgorithm;

public class Program{
    public static void Main()
    {
        try
        {
            int choice = 0;
            Console.Write("Enter text:");
            string inputString = Console.ReadLine();
            Console.Write("Enter Shifting factor:");
            int shiftingFactor = int.Parse(Console.ReadLine());

            if (shiftingFactor < 0)
            {
                throw new Exception("factor must be greater than 0");
            }
            Console.WriteLine("Press:\n1.Encrypt\n2.Decrypt\n0.Exit\n");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CaeserCipher obj=new CaeserCipher();
                
                string eText = obj.DoCeaserCipher(inputString, shiftingFactor);
                Console.WriteLine("Encrypted Text:" + eText);
            }
            else if (choice == 2)
            {
                CaeserCipher obj = new CaeserCipher();
                string dText = obj.DoCeaserCipher(inputString, -(shiftingFactor));
                Console.WriteLine("Decrypted Text:" + dText);
            }
            else if (choice == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                throw new Exception("Invalid Choice");
                Console.WriteLine();

            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();

        }
        catch (NullReferenceException ex1)
        {
            Console.WriteLine(ex1.Message);
            Console.WriteLine();
        }

    }
}
