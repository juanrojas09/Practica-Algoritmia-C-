// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;

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

    /// <summary>
    /// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
    /// </summary>
    /// <param name="inputArray"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.

    ///A 1-interesting polygon is just a square with a side of length 1. An n-interesting polygon is obtained by 
    ///taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, 
    ///side by side.You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
   public static int polygon(int n)
    {
        //calcula bien, cada n mas grande, se toma el poligono de interes anterior y se agregan mas cuadrados
        //n*n en teoria calcularia los cuadrados del poligono actual y el segundo termino los adicionales
        return n * n + (n - 1) * (n - 1);
    }


    /// <summary>
    /// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. 
    /// Since he likes to make things perfect, he wants to arrange them from smallest to
    /// largest so that each statue will be bigger than the previous one exactly by 1. 
    /// He may need some additional statues to be able to accomplish that. 
    /// Help him figure out the minimum number of additional statues needed.
    /// 
    /// Basicamente un array no consecutivo, llenarlo para que sea consecutivo y devolver el numero de push al array
    /// </summary>
    /// <param name="statues"></param>
    /// <returns></returns>
    public static int arrayconsecutive(int[] statues)
    {
        int cont = 0;

        Array.Sort(statues);
        //no muto el array original
        var arr_aux = statues;

        //para la primera posicion
        //if (arr_aux[0] + 1 == arr_aux[1])
        //{
        //    //calculo la distancia
        //   var dist= arr_aux[0] - arr_aux[1] * -1;

        //    cont += dist-1;

        //}

        for(int i = 0; i < statues.Length-1; i++)
        {
            if (arr_aux[i] + 1 != arr_aux[i+1])
            {
                //calculo la distancia
                var dist = (arr_aux[i] - arr_aux[i+1]) * -1;

                cont += dist - 1;

            }
        }

        Console.WriteLine( cont);
        return cont;

    }



    public static void Main()
    {

        //centuryFromYear(2001);
        //palindrome("aabaa");

        //int[] inputArray = new int[] {-23, 4, -3, 8, -12} ;

        //AdjacentElementsProduct(inputArray);

        int[] inputArray = new int[] { 6, 2, 3, 8 };
        arrayconsecutive(inputArray);
    }
}
