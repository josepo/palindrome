using FluentAssertions;

namespace Palindrome.Tests;

public class PalindromeTests
{
   [Theory]
   [InlineData("b", true)]
   [InlineData("bb", true)]
   [InlineData("sarabaras", true)]
   [InlineData("abccba", true)]
   [InlineData("casimrisac", false)]
   public void IsAPalindrome(string word, bool expected)
   {
      word.IsAPalindrome().Should().Be(expected);
   }
}