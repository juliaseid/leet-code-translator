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
  
    [TestMethod]
    public void Translator_LetterOReplacedWith_0()
    {
      LeetSpeakTranslator testTwo = new LeetSpeakTranslator();
      Assert.AreEqual("0", testTwo.Translate("o"));
    }

    [TestMethod]
    public void Translator_LetterIReplacedWith_1()
    {
      LeetSpeakTranslator testThree = new LeetSpeakTranslator();
      Assert.AreEqual("1", testThree.Translate("I"));
    }

    [TestMethod]
    public void Translator_LetterTReplacedWith_7()
    {
      LeetSpeakTranslator testFour = new LeetSpeakTranslator();
      Assert.AreEqual("7", testFour.Translate("t"));
    }
    [TestMethod]
    public void Translator_LetterSReplacedWith_Z()
    {
      LeetSpeakTranslator testFive = new LeetSpeakTranslator();
      Assert.AreEqual("sn4k3z", testFive.Translate("snakes"));
    }
    [TestMethod]
    public void Translator_LetterAReplacedWith_4()
    {
      LeetSpeakTranslator testSix = new LeetSpeakTranslator();
      Assert.AreEqual("4", testSix.Translate("a"));
    }

  }
}


// "e" shoud be replaced with "3"
// "o" should be replaced with "0"
// capital "I" should be replaced with "1"
// "t" should be replaced with "7"
// "s" should be replaced with "z" unless first letter of word