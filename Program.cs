// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Linq;

public class Algoritmia
{




    /// <summary>
    ///  Given a year, return the century it is in. 
    ///The first century spans from the year 1 up to and including the year 100, the second - 
    ///from the year 101 up to and including the year 200, etc.

    ///    basicamente determinar el siglo apartir del año, por ejemplo 2001 seria siglo 21
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static int centuryFromYear(int year)
    {


        // Calculo el siglo dividiendo el año por 100
        int siglo = year / 100;

        // Verifico si el año tiene dígitos adicionales más allá del siglo, si termina con un numero distinto de 0, va atener residuo
        if (year % 100 != 0)
        {
            // Si hay dígitos adicionales, incremento el siglo en 1
            siglo++;
        }
        return siglo;
    }

    /// <summary>
    /// Given the string, check if it is a palindrome.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static bool palindrome(string inputString)
    {
        var PilaDef = new Stack<string>();

        for(int i = 0; i < inputString.Length; i++)
        {
            PilaDef.Push(inputString[i].ToString());
            
        }
        //el stack es una colecciom, lo que hago es concatenar sus indices
        string JoinedString = String.Join("", PilaDef);
        if (inputString == JoinedString)
        {
            Console.WriteLine("true");
            return true;
        }
        Console.WriteLine("false");
        return false;
       

   }


    public static int AdjacentElementsProduct(int[] inputArray)
    {

        var mul = inputArray[0] * inputArray[1]; ;
        for (int i = 0; i < inputArray.Count()-1; i++)
        {
            var aux = inputArray[i] * inputArray[i + 1];
           
            if (mul < aux && aux>0)
            {
                mul = aux;
                Console.WriteLine(mul);

            }
            else
            {
                
                if (aux < 0 && mul<aux )
                {

                    mul = aux ;
                    Console.WriteLine(mul);
                }
              
            }


        }
        return mul;
    }




    public static void Main()
    {

        //centuryFromYear(2001);
        //palindrome("aabaa");

        int[] inputArray = new int[] {-23, 4, -3, 8, -12} ;
        
        AdjacentElementsProduct(inputArray);
    }
}
