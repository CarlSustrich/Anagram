using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {

    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWords_Words()
    {
      // Arrange
      Words newWords = new Words();
      // Assert
      Assert.AreEqual(typeof(Words), newWords.GetType());
      /*this takes 2 arguments, 'typeof(Words) and newWords.GetType()
      and checks their values against each other.  if they AreEqual (which I think is a TestTools specific method, then the test passes*/
    }

    [TestMethod]
    public void WordsConstructor_TestsWordsConstructor_Words()
    {
      //arrange - gather, declare and create all necessary components for the test
      string userInput = "tar";
      char[] testArray = {'a', 'r', 't'};
      Array.Sort(testArray);
      //act - invoke the functionality that we're testing
      char[] userInputToArray = Words.StringArr(userInput);
      // Array.Sort(userInputToArray);
      //assert - confirm the functionality works as anticipated by comparing the actual output with the anticipated output
      Assert.IsTrue(testArray.SequenceEqual(userInputToArray));
    }

    [TestMethod]
    public void StringCompare_TestWordsComparison_Words()
    {
      //arrange = we've got all the variables, holmes.
      string userInput = "smash";
      string comparisonWord = "smash";
      char[] userInputArray = Words.StringArr(userInput);
      char[] comparisonWordArray = Words.StringArr(comparisonWord);
      //act - we should maybe write another word specific method with 2 arguments?
      // bool stupidity = false;
      bool anagramEvaluation = Words.StringCompare(userInput, comparisonWord);
      //assert
      Assert.AreEqual(true, anagramEvaluation);
      
    }
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    [TestMethod]
    public void ExplodedWordsList_ReturnDictionaryWithSortedArray_Dictionary()
    {
      char[] testArray1 = {'a', 'r', 's', 't'};
      char[] testArray2 = {'a', 'r', 's', 't'};
      Dictionary<string, char[]> comparisonDictionary = new Dictionary<string, char[]>() { { "star", testArray1}, {"rats", testArray1} };
      Dictionary<string, char[]> comparisonDictionary2 = new Dictionary<string, char[]>() { { "star", testArray2}, {"rats", testArray2} };
      // Dictionary<string, char[]> comparisonDictionary2 = new Dictionary<string, char[]>() { { "star", testArray1}, {"rats", testArray1} };
      
      CollectionAssert.AreEquivalent(comparisonDictionary["star"], comparisonDictionary2["star"]);
    }
  }
}

/*
AreEqual
AreNotEqual
AreNotSame
AreSame
Equals
Fail
Inconclusive
IsFalse
IsInstanceOfType
IsNotInstanceOfType
IsNotNull
IsNull
IsTrue
ReplaceNullChars
ThrowsException
ThrowsException
ThrowsExceptionAsync
*/
