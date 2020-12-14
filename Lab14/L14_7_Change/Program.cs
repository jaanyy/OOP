using System;

namespace L14_7_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length - 7; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    for (int j = i; j < text.Length - 8; j++)
                    {
                        if (text.Substring(j, 9) == "</upcase>")
                        {
                            string textToEdit = text.Substring(i + 8, j - i - 8);
                            textToEdit = textToEdit.ToUpper();
                            text = text.Remove(i, j - i + 9);
                            text = text.Insert(i, textToEdit);
                            break;
                        }
                    }
                        
                }
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
