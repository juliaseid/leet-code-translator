using System;
using Translator;

namespace Program
{
  class LeetSpeak
  {
    static void Main()
    {
      Console.WriteLine("Please enter a word to translate to l33t sp34k:");
      string input = Console.ReadLine();
      LeetSpeakTranslator myTranslator = new LeetSpeakTranslator();
      string output = myTranslator.Translate(input);
      Console.WriteLine(output);
    }
  }
}