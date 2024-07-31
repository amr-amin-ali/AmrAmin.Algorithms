namespace AmrAmin.Algorithms.StringManipulationAlgorithms;

using System.Text;
using System.Text.RegularExpressions;

using AmrAmin.Algorithms.Utils;

public static class StringManipulationAlgorithms
{
    /// <summary>Checks is two sentences has the same characters but in differentg order. Implemented using sorting</summary>
    public static string AreAnagramUsingSorting(string text1, string text2)
    {
        bool result = true;
        StringManipulationUtils.PrintSearchHeader("Anagram Using Sorting");
        StringManipulationUtils.PrintContent($"Text: {text1}, {text2}");
        if (!String.IsNullOrWhiteSpace(text1) && !String.IsNullOrWhiteSpace(text2))
        {
            text1 = Regex.Replace(input: text1.Trim(), pattern: " +", replacement: " ");
            text2 = Regex.Replace(input: text2.Trim(), pattern: " +", replacement: " ");

            var arr1 = text1.ToCharArray();
            var arr2 = text2.ToCharArray();

            Array.Sort(text1.ToCharArray());
            Array.Sort(text2.ToCharArray());

            result = CompareCharArrays(arr1, arr2);
        }
        StringManipulationUtils.PrintContent($"Are Anagram = {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }
    /// <summary>Checks is two sentences has the same characters but in differentg order. Implemented using histogramming</summary>
    public static string AreAnagramUsingHistogramming(string text1, string text2)
    {
        bool result = true;
        StringManipulationUtils.PrintSearchHeader("Anagram Using Histogramming");
        StringManipulationUtils.PrintContent($"Text: {text1}, {text2}");
        if (!String.IsNullOrWhiteSpace(text1) && !String.IsNullOrWhiteSpace(text2))
        {
            const int ENGLISH_ALPHABET = 26;
            int[] frequences = new int[ENGLISH_ALPHABET];
            text1 = Regex.Replace(input: text1.Trim(), pattern: " +", replacement: "").ToLower();
            text2 = Regex.Replace(input: text2.Trim(), pattern: " +", replacement: "").ToLower();

            for (int i = 0; i < text1.Length; i++)
            {
                var ch = text1[i];
                int index = ch - 'a';
                frequences[index]++;
            }
            for (int i = 0; i < text2.Length; i++)
            {
                var ch = text2[i];
                int index = ch - 'a';
                int d = frequences[ch - 'a'];

                if (frequences[index] == 0)
                {
                    result = false;
                    break;
                }
                index--;
            }
        }
        StringManipulationUtils.PrintContent($"Are Anagram = {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }

    public static string CapitalizeFirstChar(string text)
    {
        var result = new StringBuilder();
        StringManipulationUtils.PrintSearchHeader("Capitalize First Char");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (!String.IsNullOrWhiteSpace(text.Trim()))
        {
            text = Regex.Replace(input: text.Trim(), pattern: " +", replacement: " ");

            var firstChar = text[0].ToString().ToUpper();
            var rest = text.Substring(1).ToLower();
            result.Append(firstChar);
            result.Append(rest);

        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }
    public static string Capitalize(string text)
    {
        var result = new StringBuilder();
        StringManipulationUtils.PrintSearchHeader("Capitalize");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (!String.IsNullOrWhiteSpace(text.Trim()))
        {
            text = Regex.Replace(input: text.Trim(), pattern: " +", replacement: " ");
            var words = text.Trim().Split(' ');
            foreach (var word in words)
            {
                var a = word.Substring(0, 1).ToUpper();
                var b = word.Substring(1).ToLower();
                result.Append(a);
                result.Append(b);
                result.Append(" ");
            }
        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString().Trim();
    }

    public static char? MostRepeated(string text)
    {
        char? result = null;
        StringManipulationUtils.PrintSearchHeader("Most Repeated");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {
            var counter = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (counter.ContainsKey(ch))
                {
                    counter[ch]++;
                }
                else
                {
                    counter.Add(ch, 0);
                }
            }


            result = counter.OrderByDescending(c => c.Value).First().Key;


        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result;
    }
    public static char? MostRepeatedV2(string text)
    {
        char? result = null;
        StringManipulationUtils.PrintSearchHeader("Most Repeated V2");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {
            const int ASCII_SIZE = 256;
            int[] frequencies = new int[ASCII_SIZE];
            foreach (var ch in text.ToCharArray())
            {
                frequencies[ch]++;
            }
            int max = 0;
            for (int i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] > max)
                {
                    max = frequencies[i];
                    result = (char)i;
                }
            }
        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result;
    }
    public static string RemoveDuplicates(string text)
    {
        var result = new StringBuilder();
        StringManipulationUtils.PrintSearchHeader("RemoveDuplicates");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {

            foreach (var item in text)
            {
                if (!result.ToString().Contains(item))
                {
                    result.Append(item);
                }
            }
        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }
    public static bool AreRotations(string text1, string text2)
    {
        var result = true;
        StringManipulationUtils.PrintSearchHeader("Are Rotations");
        StringManipulationUtils.PrintContent($"Text: {text1}, {text2}");
        if (text1 is not null and not null)
        {

            result = text1.Length == text2.Length
                && (text1 + text1).Contains(text2);



        }
        StringManipulationUtils.PrintContent($"Result: Are Rotations = {result}");
        StringManipulationUtils.PrintStringFooter();
        return result;
    }

    public static string Rotate(string text)
    {
        var result = new StringBuilder();
        StringManipulationUtils.PrintSearchHeader("Rotate by 1");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {
            var lastChar = text.Substring(text.Length - 1, 1);
            var textExceptLastChar = text.Substring(0, text.Length - 1);
            result.Append(lastChar);
            result.Append(textExceptLastChar);



        }
        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }
    public static string ReverseWordsV1(string text)
    {
        var result = new StringBuilder();
        StringManipulationUtils.PrintSearchHeader("Reverse Words");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {
            var words = text.Split(" ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result.Append(words[i]);
                result.Append(" ");
            }
        }



        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString().Trim();
    }
    public static string ReverseWordsV2(string text)
    {
        var result = "";
        StringManipulationUtils.PrintSearchHeader("Reverse Words");
        StringManipulationUtils.PrintContent($"Text: {text}");
        if (text is not null)
        {
            var words = text.Split(" ").Reverse().ToList();
            result += string.Join(" ", words);
        }



        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result;
    }

    public static int CountVowels(string text)
    {
        int count = 0;
        string vowels = "eaiou";
        StringManipulationUtils.PrintSearchHeader("Count Vowel");

        if (text is not null)
        {


            foreach (char ch in text.ToLower())
            {
                if (vowels.IndexOf(ch) != -1)
                {
                    count++;
                }
            }
        }
        StringManipulationUtils.PrintContent($"Text: {text}");
        StringManipulationUtils.PrintContent($"Vowels count: {count}");




        StringManipulationUtils.PrintStringFooter();
        return count;
    }
    public static string Reverse(string text)
    {
        StringManipulationUtils.PrintSearchHeader("Reverse");
        StringManipulationUtils.PrintContent($"Text: {text}");
        var result = new StringBuilder();

        if (text is not null)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }
        }



        StringManipulationUtils.PrintContent($"Result: {result}");
        StringManipulationUtils.PrintStringFooter();
        return result.ToString();
    }

    private static bool CompareCharArrays(char[] arr1, char[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}
