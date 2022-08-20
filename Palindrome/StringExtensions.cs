namespace Palindrome;

public static class StringExtensions
{
   public static bool IsAPalindrome(this string word)
   {
      var reversedWord = new String(word.Reverse().ToArray());

      return word == reversedWord;
   }
}
