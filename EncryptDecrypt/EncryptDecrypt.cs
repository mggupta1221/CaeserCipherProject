using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace EncryptDecrypt
{
    public class EncryptDecrypts
    {
        public string inputString{get; private set;}
        private string EncryptedText = "";
        private string DeccryptedText = "";

        public int Factor { get; private set; }

        public EncryptDecrypts(string text, int factor)
        {
            this.inputString = text;
            this.Factor = factor;
        }
        public EncryptDecrypts()
        {

        }

        public string Encrypt(string inputString,int shiftingFactor) // Forward dir
        {
            EncryptDecrypts e = new EncryptDecrypts(inputString, shiftingFactor);

            for (int count = 0; count < inputString.Length; count++)
            {
                int charInt = (int)(inputString[count]);
                if (IsAlphabet(charInt))
                {
                    int charIntWithFactor = charInt + shiftingFactor;
                    if (((charIntWithFactor >= 65 && charIntWithFactor <= 90) && (charInt >= 65 && charInt <= 90)) || ((charIntWithFactor >= 97 && charIntWithFactor <= 122) && (charInt >= 97 && charInt <= 122)))
                    {
                        char c = (char)charIntWithFactor;
                        EncryptedText += c;
                    }
                    else
                    {
                        if ((charInt >= 65 && charInt <= 90) )
                        {

                            charIntWithFactor = 64 + (charIntWithFactor - 90);
                            char c = (char)charIntWithFactor;
                            EncryptedText += c;
                        }
                        else if ((charInt >= 97 && charInt <= 122)) //lower
                        {
                            charIntWithFactor = 96 + (charIntWithFactor - 122);
                            char c = (char)charIntWithFactor;
                            EncryptedText += c;
                        }
                    }
                }
                else
                {
                    EncryptedText += inputString[count];
                }
            }
            return EncryptedText;
        }
        public bool IsAlphabet(int eachCharInt)
        {
            if ((eachCharInt >= 65 && eachCharInt <= 90) || (eachCharInt >= 97 && eachCharInt <= 122))
            {
                return true;
            }
            return false;
        }
        public string Decrypt(string inputString, int shiftingFactor)//reverse dir
        {
            EncryptDecrypts e = new EncryptDecrypts(inputString, shiftingFactor);
            for (int count = 0; count < inputString.Length; count++)
            {
                int charInt = (int)(inputString[count]);
                if (IsAlphabet(charInt))
                {
                    int charIntwithFactor = charInt - shiftingFactor;
                    if (((charIntwithFactor >= 65 && charIntwithFactor <= 90) && (charInt >= 65 && charInt <= 90)) || ((charIntwithFactor >= 97 && charIntwithFactor <= 122) && (charInt >= 97 && charInt <= 122)))
                    {
                        char c = (char)charIntwithFactor;
                        DeccryptedText += c;
                    }

                    else
                    {
                        if ((charInt >= 65 && charInt <= 90))
                        {
                            if (charIntwithFactor < 65)
                            {
                                charIntwithFactor = 90 - (64 - charIntwithFactor);
                              
                            }
                         
                            char c = (char)charIntwithFactor;
                            DeccryptedText += c;

                        }
                        else if ((charInt >= 97 && charInt <= 122)) //lower
                        {

                            if (charIntwithFactor < 97)
                            {
                                charIntwithFactor = 122 - (96 - charIntwithFactor);

                            }

                            char c = (char)charIntwithFactor;
                            DeccryptedText += c;
                        }

                    }
                }
                else
                {
                    DeccryptedText += inputString[count];
                }
            }
            return DeccryptedText;
        }
        public static void Main()
        {
            try
            {
                int choice = 0;
                EncryptDecrypts e = new EncryptDecrypts();
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
                    string eText = e.Encrypt(inputString,shiftingFactor);
                    Console.WriteLine("Encrypted Text:" + eText);
                }
                else if (choice == 2)
                {
                    
                    string dText = e.Decrypt(inputString, shiftingFactor);
                    Console.WriteLine("Decrypted Text:" + dText);
                }
                else if (choice == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    throw new Exception("");
                    Console.WriteLine();
                   
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                
            }
            catch(NullReferenceException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine() ;
            }
            
        }


    }
}