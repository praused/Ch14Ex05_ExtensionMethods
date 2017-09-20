﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionLib
{
    public static class WordProcessor //the extension method class, must be a nongeneric static class.
    {
        public static List<string> GetWords(this string sentence, bool capitalizeWords = false, bool reverseOrder = false, bool reverseWords = false)
        //an extension method, extending string
        {
            List<string> words = new List<string>(sentence.Split(' '));
            if (capitalizeWords) words = CapitalizeWords(words);
            if (reverseOrder) words = ReverseOrder(words);
            if (reverseWords) words = ReverseWords(words);
            return words;
        }

        public static string ToStringReversed(this object inputObject)
        //an extension method, extending object
        {
            return ReverseWord(inputObject.ToString());
        }

        public static string AsSentence(this List<string> words)
        //an extension method, extending List<string>
        {
            StringBuilder sb = new StringBuilder();
            for (int wordIndex = 0; wordIndex < words.Count; wordIndex++)
            {
                sb.Append(words[wordIndex]);
                if (wordIndex != words.Count - 1) sb.Append(' ');
            }
            return sb.ToString();
        }

        private static List<string> ReverseWords(List<string> words)
        {
            List<string> reversedWords = new List<string>();
            foreach (string word in words)
            {
                reversedWords.Add(ReverseWord(word));
            }
            return reversedWords;
        }

        private static string ReverseWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int characterIndex = word.Length - 1; characterIndex >= 0; characterIndex--)
            {
                sb.Append(word[characterIndex]);
            }
            return sb.ToString();
        }

        private static List<string> ReverseOrder(List<string> words)
        {
            List<string> reversedOrder = new List<string>();
            for (int wordIndex = words.Count - 1; wordIndex >= 0; wordIndex--)
            {
                reversedOrder.Add(words[wordIndex]);
            }
            return reversedOrder;
        }

        private static List<string> CapitalizeWords(List<string> words)
        {
            List<string> capitalizedWords = new List<string>();
            foreach (string word in words)
            {
                if (word.Length == 0) continue;
                if (word.Length == 1) capitalizedWords.Add(word[0].ToString().ToUpper());
                else capitalizedWords.Add(word[0].ToString().ToUpper() + word.Substring(1));
            }
            return capitalizedWords;
        }
    }
}
