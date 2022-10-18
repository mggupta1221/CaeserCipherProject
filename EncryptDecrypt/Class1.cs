//using EncryptDecrypt;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EncryptDecrypt
//{
//    internal class Class1
//    {
//    }
//}


//public string? s;
//public string? s1 = "";
//public int factor;
//public static void Main()
//{

//    EncryptDecrypts e = new EncryptDecrypts();
//    try
//    {
//        Console.WriteLine("Enter text:");
//        e.s = Console.ReadLine();

//        Console.WriteLine("Enter factor:");
//        e.factor = int.Parse(Console.ReadLine());

//        for (int i = 0; i < e.s.Length; i++)
//        {
//            int charInt = (int)(e.s[i]);
//            if ((charInt >= 65 && charInt <= 90) || (charInt >= 97 && charInt <= 122))
//            {
//                int charIntInc = charInt + e.factor;
//                if ((charIntInc >= 65 && charIntInc <= 90) || (charIntInc >= 97 && charIntInc <= 122))
//                {
//                    char c = (char)charIntInc;
//                    e.s1 += c;
//                }
//                else
//                {
//                    if ((charInt >= 65 && charInt <= 90))
//                    {
//                        charIntInc = 64 + (charIntInc - 90);
//                        char c = (char)charIntInc;
//                        e.s1 += c;
//                    }
//                    if ((charInt >= 97 && charInt <= 122))
//                    {
//                        charIntInc = 96 + (charIntInc - 122);
//                        char c = (char)charIntInc;
//                        e.s1 += c;
//                    }

//                }
//            }
//            else
//            {
//                e.s1 += e.s[i];
//            }
//        }
//        Console.WriteLine("Encrypted Text:");
//        Console.WriteLine(e.s1);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine(ex.Message);
//        Console.WriteLine();
//    }


//}