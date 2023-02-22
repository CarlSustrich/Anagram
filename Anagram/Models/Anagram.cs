using System;
using System.Linq;
using System.Collections.Generic;

namespace Anagram.Models
{

  public class Words
  {
    public static char[] StringArr(string input)
    {
      char[] inputArray = input.ToCharArray();
      Array.Sort(inputArray);
      return inputArray;
    }

    public static bool StringCompare(string standardWord, string comparisonWord)
    {
      char[] standardWordArray = Words.StringArr(standardWord);
      char[] comparisonWordArray = Words.StringArr(comparisonWord);
      return standardWordArray.SequenceEqual(comparisonWordArray);
    }

    public static Dictionary<string, char[]> ExplodeWordList(string multipleWords)
    {
      Dictionary<string, char[]> testDictionary = new Dictionary<string, char[]>();
      string[] explodedWordsArray = multipleWords.Split(' ');
      // ["star", "rats", "arts"]
      // for (int index = 0; index < explodedWordsArray.Length; index++)
      // {
      //   //add the value of the index to the key section of the dictionary
      //   //add the array of the exploded word to it's corresponding value section
      //   // {star: ['s','t','a','r'], rats: ['r','a','t','s']}
      //   testDictionary[explodedWordsArray[index]] = Words.StringArr(explodedWordsArray[index]);
      // }
      foreach (string element in explodedWordsArray)
      {
        char[] charVariable = Words.StringArr(element);
        testDictionary.Add(element, charVariable);
      }
    
      return testDictionary;
      //this is the place for an overload function maybe
      //Dictionary:{ [ star:{'s','t','a','r'} ], [ rats:{'r','a','t','s']}], etc. etc. 
// Dictionary<string, int> cupcakeOrder = new Dictionary<string, int>() { {"vanilla", 12}, {"chocolate", 24}, {"raspberry", 6}, {"caramel apple", 36} };
// foreach (KeyValuePair<string, int> cupcake in cupcakeOrder)
// {
//   Console.WriteLine($"{cupcake.Key}: {cupcake.Value}");
// }
      /*
      1st word = star    list = rats, tars, arts,  <-- all of these ARE anagrams
      */
    }
  }
}
