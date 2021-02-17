using System;
using System.Diagnostics;

namespace FirstProject
{

    static void Main(string[] args)
    {
        string s, rev = "";
        Console.WriteLine("Enter String:");
        s = Console.ReadLine();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(s[i]);
        }
        {
            Console.WriteLine("----------------");
            for (int i = s.Length; i >= 0; i--)
            {
                ;
            }

            {
                Console.WriteLine(s[i]);
                rev += s[i].ToString();
            }
            Console.WriteLine(rev);
            if (s == rev)
            { 
        Console.WriteLine("It is a palindrome. Entered string is : {0) and the recerse string is : {1}", s, rev);
    } 
else 
    {
    Console.WriteLine("It is not a palindrome. Enterd string is : {0} and the reverse string is {1}", s rev);
        }
    }
  }
 }
