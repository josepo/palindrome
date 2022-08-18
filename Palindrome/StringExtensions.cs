namespace Palindrome;

public static class StringExtensions
{
   public static bool IsAPalindrome(this string word)
   {
      for (var i = 0; i < word.Length / 2; i++)
         if (word[i] != word[word.Length - (i + 1)])
            return false;

      return true;
   }
}
