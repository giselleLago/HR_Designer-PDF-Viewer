using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word)
    {
        var res = 0;
        var resFinal = 0;
        List<int> wordList = new List<int>();
        for (int i = 0; i <= word.Length - 1; i++)
        {
            var index = ((int)word[i] - 97);
            res = h[index];
            wordList.Add(res);
            
        }
        var MaxValue = wordList.Max();
        var WordLength = word.Length;
        resFinal = MaxValue * WordLength;
        return resFinal;
    }

    static void Main(string[] args)
    {
        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}