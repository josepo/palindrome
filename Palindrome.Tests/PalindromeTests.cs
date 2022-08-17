namespace Palindrome.Tests;

public class PalindromeTests
{
   [Fact]
   public void OneLetterWord()
   {
      var word = "b";

      Assert.True(word.IsAPalindrome());
   }
}