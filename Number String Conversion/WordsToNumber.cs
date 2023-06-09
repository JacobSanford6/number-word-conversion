﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jake Sanford
//04/08/2023
//This class allows for the user to convert words to number values
//And words into number values
namespace Number_String_Conversion
{
    public static class WordsToNumber
    {
        //Create arrays to search for number values
        private static string[] onesList = { "", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
        private static string[] tensList = { "", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety" };
        private static string[] thousandsList = { " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion", " undecillion", " duodecillion", " tredecillion", " quattuordecillion", " quindecillion", " sexdecillion", " septendecillion", " octodecillion", " novemdecillion", " vigintillion" };

        //Creates sets for words
        //A set is a group of three digits
        //In this case we split the string by each thousands place value to obtain each set
        // number = words for number ex: twelve thousand one hundred
        private static List<string> getSets(string number)
        {
            List<string> sets = new List<string>();
            int lastWord = -1;
            string[] split = number.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                string word = split[i];

                int thousandsPos = Array.IndexOf(thousandsList, " " + word);
                if (thousandsPos != -1)
                {
                    string part = " ";
                    for (int ii = lastWord+1; ii < i; ii++)
                    {
                        part += split[ii] + " ";
                    }
                    lastWord = i;
                    sets.Add(part);
                }

                if (i == split.Length - 1)
                {
                    string lastPart = " ";
                    for (int ii = lastWord + 1; ii <= i; ii++)
                    {
                        lastPart += split[ii] + " ";
                    }
                    sets.Add(lastPart);
                }
            }
            return sets;
        }

        //Gets the thousands multiplier for each set.. ex output:
        //getThousandSetValues("twelve million") = 1000000
        //This is done by getting all thousands identifiers and adding them to a list
        //That contains the respective value for the thousands identifier
        // number = words for number ex: twelve thousand one hundred
        private static List<long> getThousandSetValues(string number)
        {
            List<long> returnVal = new List<long>();
            string[] split = number.Split(' ');
            foreach (string wordd in split)
            {
                string word = wordd.Trim();

                if (Array.IndexOf(thousandsList, " " + word) != -1)
                {
                     returnVal.Add((long)( Math.Pow(1000,  Array.IndexOf(thousandsList, " " + word) + 1 ) ));
                }
            }
            returnVal.Add(1);
            return returnVal;
        }

        //Gets the value of a set
        //This is done by first checking for hundreds values
        //If there is hundreds values, remove the set from the words array by setting to ""
        //This allows me to search the rest of the set for any remaining ten or one values (one values range from 1 to 19
        // Set = set value ex: twelve
        private static long getSetValue( string set )
        {
            int hundreds=0;
            int tens=0;
            int ones=0;
            
            string[] words = set.Split(' ');

            if (set.Contains("hundred"))
            {
                hundreds = Array.IndexOf(onesList, " " + words[0]);
                words[0] = "";
                words[1] = "";
            }

            foreach (string word in words)
            {
                if (word != "")
                {
                    if (word.Contains("-"))
                    {
                        string[] wordSplit = word.Split('-');
                        tens = Array.IndexOf(tensList, " " + wordSplit[0])+1;
                        ones = Array.IndexOf(onesList, " " + wordSplit[1]);
                    }
                    else
                    {
                        if (Array.IndexOf(tensList, " " + word) != -1)
                        {
                            tens = Array.IndexOf(tensList, " " + word)+1;
                        }
                        else
                        {
                            ones = Array.IndexOf(onesList, " " + word);
                        }
                    }
                }
            }
            return ((hundreds*100) + (tens*10) + ones);
        }

        //Converts word number to long value
        //This is done by first checking if the number is negative
        //Then we get the set values for the input words and multiply them with
        //The thousands set values to obtain our long number
        // number = words for number ex: twelve thousand one hundred
        /// <summary>Converts word number to long value</summary>
        /// <param name="words">Ex: twelve million</param>
        public static long Convert(string words)
        {
            string newWords = words;
            int negativeMult = 1;
            if (newWords.StartsWith("zero")){
                return 0;
            }else if (newWords.StartsWith("minus"))
            {
                negativeMult = -1;
                newWords = words.Substring(6);
            }else if (newWords.StartsWith("negative"))
            {
                negativeMult = -1;
                newWords = words.Substring(9);
            }

            List<string> sets;
            sets = getSets(newWords);
            List<long> thousandsMults = getThousandSetValues(newWords);
            long total = 0;

            for (int i = 0; i< sets.Count; i++)
            {
                string set = sets[i].Trim();
                long setVal = getSetValue(set);
                total += setVal * thousandsMults[i];
            }
            return total*negativeMult;
        }
    } 
}

