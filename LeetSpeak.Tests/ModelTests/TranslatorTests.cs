using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.TestTools
{
  [TestClass]
  public class TranslatorTests
  {
    [TestMethod]
    public void Translator_LetterEReplacedWith_3()
    {
      LeetSpeakTranslator testOne = new LeetSpeakTranslator();
      Assert.AreEqual("3", testOne.Translate("e"));
    }
  }
}


// "e" shoud be replaced with "3"
// "o" should be replaced with "0"
// capital "I" should be replaced with "1"
// "t" should be replaced with "7"
// "s" should be replaced with "z" unless first letter of word