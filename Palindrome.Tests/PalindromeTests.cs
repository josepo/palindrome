namespace Palindrome.Tests;

public class PalindromeTests
{
   [Fact]
   public void OneLetterWord()
   {
      var word = "b";

      Assert.True(word.IsAPalindrome());
   }

   [Fact]
   public void SameLetterTwiceWord()
   {
      var word = "bb";

      Assert.True(word.IsAPalindrome());
   }

   [Fact]
   public void LongPalindrome()
   {
      var word = "sarabaras";

      Assert.True(word.IsAPalindrome());
   }

   [Fact]
   public void NotAPalindrome()
   {
      var word = "casimrisac";

      Assert.False(word.IsAPalindrome());
   }
}