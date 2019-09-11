using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Utilities 
{
    public static string ProcessText(string input)
    {
        //your code goes here:
        //Determine whether user has input a word or a number,
        //Return the string 'word' if user enters a word (includes 'ab.23cd')
        //Return the string 'number if user enters a number (includes 1.3)
        double number;
         string[] separateStrings = input.Split(' ');
         int wordCount = 0;
         int numCount = 0;

         foreach (var word in separateStrings)
         {
             try
             {
                 number = double.Parse(word);

                 numCount++;
             }
             catch
             {
                 wordCount++;
             }
         }

         return ($"Words: {wordCount} Numbers: {numCount}");
         
         /*
        try
        {
            number = double.Parse(input);

            return "number";
        }
        catch
        {
            return "word";
        }
        */
        //return input;
    }
}
