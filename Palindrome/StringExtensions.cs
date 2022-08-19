namespace Palindrome;

public static class StringExtensions
{
   public static bool IsAPalindrome(this string word)
   {
      int i = 0;
      int length = word.Length;
      bool palindrome = true;

      while (palindrome && i < length / 2)
      {
         if (word[i] != word[length - (i + 1)])
            palindrome = false;

         i++;
      }

      return palindrome;
   }
}
