using System;
using System.Security.Cryptography.X509Certificates;

namespace EncryptDecrypt
{
    public class EncryptDecrypts
    {
        public string Text{get; private set;}
        private string EncryptedText = "";
        private string DeccryptedText = "";

        public int Factor { get; private set; }

        public EncryptDecrypts(string text, int factor)
        {
            this.Text = text;
            this.Factor = factor;
        }
        public EncryptDecrypts()
        {

        }

        public string Encrypt() // Forward dir
        {
            for (int i = 0; i < Text.Length; i++)
            {
                int charInt = (int)(Text[i]);
                if ((charInt >= 65 && charInt <= 90) || (charInt >= 97 && charInt <= 122))
                {
                    int charIntWithFactor = charInt + Factor;
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
                    EncryptedText += Text[i];
                }
            }
            return EncryptedText;
        }
        public string Decrypt()//reverse dir
        {
            for (int i = 0; i < Text.Length; i++)
            {
                int charInt = (int)(Text[i]);
                if ((charInt >= 65 && charInt <= 90) || (charInt >= 97 && charInt <= 122))
                {
                    int charIntInc = charInt - Factor;
                    if (((charIntInc >= 65 && charIntInc <= 90) && (charInt >= 65 && charInt <= 90)) || ((charIntInc >= 97 && charIntInc <= 122) && (charInt >= 97 && charInt <= 122)))
                    {
                        char c = (char)charIntInc;
                        DeccryptedText += c;
                    }

                    else
                    {
                        if ((charInt >= 65 && charInt <= 90))
                        {
                            if (charIntInc < 65)
                            {
                                charIntInc = 90 - (64 - charIntInc);
                              
                            }
                         
                            char c = (char)charIntInc;
                            DeccryptedText += c;

                        }
                        else if ((charInt >= 97 && charInt <= 122)) //lower
                        {

                            if (charIntInc < 97)
                            {
                                charIntInc = 122 - (96 - charIntInc);

                            }

                            char c = (char)charIntInc;
                            DeccryptedText += c;
                        }

                    }
                }
                else
                {
                    DeccryptedText += Text[i];
                }
            }
            return DeccryptedText;
        }
        public static void Main()
        {
            start:
            try
            {
                int choice = 0;
               
                Console.Write("Enter text:");
                string s = Console.ReadLine();
                Console.Write("Enter factor:");
                int factor = int.Parse(Console.ReadLine());

                if (factor < 0)
                {
                    throw new Exception("factor must be greater than 0");
                }
                Console.WriteLine("Press:\n1.Encrypt\n2.Decrypt");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    EncryptDecrypts e = new EncryptDecrypts(s, factor);
                    string eText = e.Encrypt();
                    Console.WriteLine("Encrypted Text:" + eText);
                }
                else if (choice == 2)
                {
                    EncryptDecrypts e = new EncryptDecrypts(s, factor);
                    string dText = e.Decrypt();
                    Console.WriteLine("Decrypted Text:" + dText);
                }
                else
                {
                    throw new Exception("Choice must be either 1 or 2:");
                    Console.WriteLine();
                    goto start;
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                goto start;
            }
            
        }


    }
}