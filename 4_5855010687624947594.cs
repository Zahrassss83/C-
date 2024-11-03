// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class PROGRAM
{
    static void MAIN()
    {
        String INPUT = "HERE are some numbers: 0123456789, 0234567890, and 0123456780.also,0123456789 is repeated.";

        List<string> phonenumbers = extraactphonenumber(INPUT);

        if (phonenumbers.Count >= 2)
        {
            Console.WriteLine("valid phone numbers found:");
            foreach (var number in phonenumbers)
            {
                Console.WriteLine(number);
            }

        }
        else
        {
            Console.WriteLine("not enough valid phone numbers found.");
        }
    }
    static List<string> extract phonenumbers(string input);
    {
    //regex pattern for matching phone numbers starting with '0' and having exactly 10 digits
    string pattern = @"\b0\d{9}\b";
    MatchCollection matches = Regex.Matches(input, pattern);

    //use a hashset to ensure we  only keep unique numbers 
    HashSet<string>
        foreach(Match matchin matches)
        {
      unique numbers.add(Match value);
        }
return uniquenumbers.tolist();

