using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private string EncryptedText = "";
        private string DeccryptedText = "";
        private bool IsAlphabet(int charCheck)
        {
            return ((IsCapitalAlphabet(charCheck) || IsSmallAlphabet(charCheck)));
        }
        private bool IsCapitalAlphabet(int charCheck)
        {
            return (charCheck >= 65 && charCheck <= 90);
        }
        private bool IsSmallAlphabet(int charCheck)
        {
            return (charCheck >= 97 && charCheck <= 122);
        }
        public string DoCeaserCipher(string inputString,int shiftingFactor) // Forward dir
        {

            if (shiftingFactor > 0) //if we want to do encryption forward
            {
                for (int count = 0; count < inputString.Length; count++)
                {
                    int charInt = (int)(inputString[count]);
                    if (IsAlphabet(charInt))
                    {
                        int charIntWithFactor = charInt + shiftingFactor;
                        if ((IsCapitalAlphabet(charIntWithFactor) && IsCapitalAlphabet(charInt)) || ((IsSmallAlphabet(charIntWithFactor) && IsSmallAlphabet(charInt))))
                        {
                            char c = (char)charIntWithFactor;
                            EncryptedText += c;
                        }
                        else
                        {
                            if (IsCapitalAlphabet(charInt))
                            {
                                charIntWithFactor = 64 + (charIntWithFactor % 90);
                                char c = (char)charIntWithFactor;
                                EncryptedText += c;
                            }
                            else if (IsSmallAlphabet(charInt)) //lower
                            {
                                charIntWithFactor = 96 + (charIntWithFactor % 122);
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

            else
            {
                for (int count = 0; count < inputString.Length; count++)
                {
                    int charInt = (int)(inputString[count]);
                    if (IsAlphabet(charInt))
                    {
                        int charIntwithFactor = charInt + shiftingFactor;
                        if ((IsCapitalAlphabet(charIntwithFactor) && IsCapitalAlphabet(charInt)) || ((IsSmallAlphabet(charIntwithFactor) && IsSmallAlphabet(charInt))))
                        {
                            char c = (char)charIntwithFactor;
                            DeccryptedText += c;
                        }

                        else
                        {
                            if (IsCapitalAlphabet(charInt))
                            {
                                if (charIntwithFactor < 65)
                                {
                                    charIntwithFactor = 90 - (64 - charIntwithFactor);
                                }
                                char c = (char)charIntwithFactor;
                                DeccryptedText += c;
                            }
                            else if (IsSmallAlphabet(charInt) && charIntwithFactor < 97) //lower
                            {
                                charIntwithFactor = 122 - (96 - charIntwithFactor);
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
            
        }
    }
}