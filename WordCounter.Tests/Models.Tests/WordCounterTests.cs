using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void Constructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      // Arrange
      string word = "cat";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, "");

      // Act
      string result = newRepeatCounter.GetWord();

      // Assert
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetsWord_Void()
    {
      // Arrange
      string word = "cat";
      RepeatCounter newRepeatCounter = new RepeatCounter(word, "");
      // Act
      string newWord = "dog";
      newRepeatCounter.SetWord(newWord);
      string result = newRepeatCounter.GetWord();
      // Assert
      Assert.AreEqual(newWord, result);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      // Arrange
      string sentence = "I like my cat";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string result = newRepeatCounter.GetSentence();
      // Assert
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_SetsSentence_Void()
    {
      // Arrange
      string sentence = "I like my cat.";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string newSentence = "I like my dog.";
      newRepeatCounter.SetSentence(newSentence);
      string result = newRepeatCounter.GetSentence();
      // Assert
      Assert.AreEqual(newSentence, result);
    }

    [TestMethod]
    public void SplitSentence_ReturnsWords_StringArray()
    {
      // Arrange
      string sentence = "I like my cat";
      RepeatCounter newRepeatCounter = new RepeatCounter("", sentence);
      // Act
      string[] newSentence = {"I", "like", "my", "cat"};
    string [] result = newRepeatCounter.SplitSentence();
      // Assert
      CollectionAssert.AreEqual(newSentence, result);
    }

    [TestMethod]
    public void CountWords_CountWordsFromSentence_Int()
    {
    // Arrange
    int result = 1;
    string word = "cat";
    string sentence = "I like my cat";
    RepeatCounter newRepeatCounter = new RepeatCounter(word, sentence);
    // Act
    int newResult = newRepeatCounter.CountWords();
    // Assert
    Assert.AreEqual(result, newResult);
  }
  }
}
