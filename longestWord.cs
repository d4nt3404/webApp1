using System;
using System.Text.RegularExpressions;
using System.Linq;

class MainClass {

  public static string LongestWord(string sen) {

    // code goes here  3
    if (String.IsNullOrEmpty(sen))
    {
        return "sen will not be empty. ";
    }
        sen = Regex.Replace(sen, @"[^0-9a-zA-Z ]+", "");
         
        string[] words = sen.Split(' ');
        return words.OrderByDescending(x => x.Length).First();

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(LongestWord(Console.ReadLine()));
  } 

}
