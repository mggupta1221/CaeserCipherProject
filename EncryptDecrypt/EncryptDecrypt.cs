using System;
using System.Security.Cryptography.X509Certificates;

namespace EncryptDecrypt
{
    public class EncryptDecrypts
    {
        public string Text{get; private set;}
        public string EncryptedText = "";
        public int Factor { get; private set; }

        public EncryptDecrypts(string text, int factor)
        {
            this.Text = text;
            this.Factor = factor;


        }
        public EncryptDecrypts()
        {

        }

        public string Encrypt()
        {
            for (int i = 0; i < Text.Length; i++)
            {
                int charInt = (int)(Text[i]);
                if ((charInt >= 65 && charInt <= 90) || (charInt >= 97 && charInt <= 122))
                
                
                
                {
                    int charIntInc = charInt + Factor;
                    if (((charIntInc >= 65 && charIntInc <= 90) && (charInt >= 65 && charInt <= 90)) || ((charIntInc >= 97 && charIntInc <= 122) && (charInt >= 97 && charInt <= 122)))
                    {
                        char c = (char)charIntInc;
                        EncryptedText += c;
                    }

                    else
                    {
                        if ((charInt >= 65 && charInt <= 90) )
                        {

                            charIntInc = 64 + (charIntInc - 90);
                            char c = (char)charIntInc;
                            EncryptedText += c;
                        }
                        else if ((charInt >= 97 && charInt <= 122)) //lower
                        {
                            charIntInc = 96 + (charIntInc - 122);
                            char c = (char)charIntInc;
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

        public static void Main()
        {
            start:
            try
            {
               
                Console.Write("Enter text:");
                string s = Console.ReadLine();
                Console.Write("Enter factor:");
                int factor = int.Parse(Console.ReadLine());

                if (factor < 0)
                {
                    throw new Exception("factor must be greater than 0");
                }
                EncryptDecrypts e = new EncryptDecrypts(s, factor);
                string eText = e.Encrypt();
                Console.WriteLine("Encrypted Text:" + eText);
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