using FluentAssertions;

namespace Palindrome.Tests;

public class PalindromeTests
{
   [Fact]
   public void OneLetterWord()
   {
      var word = "b";

      word.IsAPalindrome().Should().BeTrue();
   }

   [Fact]
   public void SameLetterTwiceWord()
   {
      var word = "bb";

      word.IsAPalindrome().Should().BeTrue();
   }

   [Fact]
   public void LongPalindrome()
   {
      var word = "sarabaras";

      word.IsAPalindrome().Should().BeTrue();
   }

   [Fact]
   public void NotAPalindrome()
   {
      var word = "casimrisac";

      word.IsAPalindrome().Should().BeFalse();
   }
}