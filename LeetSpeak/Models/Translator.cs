using System;
using System.Collections.Generic;

namespace Translator
{
  public class LeetSpeakTranslator
  {
    public string Translate(string input)
    {
      char[] StartingArray = input.ToCharArray();
      for (int i = 0; i < StartingArray.Length; i ++)
        if (StartingArray[i] == 'e')
        {
          StartingArray[i] = '3';
        }
        else if(StartingArray[i] == 'o')
        {
          StartingArray[i] = '0';
        }
        else if(StartingArray[i] == 'I')
        {
          StartingArray[i] = '1';
        }
        else if(StartingArray[i] == 't')
        {
          StartingArray[i] = '7';
        }
        else if(StartingArray[i] == 's' && i != 0)
        {
          StartingArray[i] = 'z';
        }
        else if(StartingArray[i] == 'a')
        {
          StartingArray[i] = '4';
        }
        else
        {
          StartingArray[i] = StartingArray[i];
        }
      string result = string.Join("", StartingArray);
      return result;
    }
  }

}