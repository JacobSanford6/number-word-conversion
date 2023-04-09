using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_String_Conversion
{
    public static class stringToNumber
    {
        private static string[] onesList = { "", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
        private static string[] tensList = { "", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety" };
        private static string[] thousandsList = { " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion", " undecillion", " duodecillion", " tredecillion", " quattuordecillion", " quindecillion", " sexdecillion", " septendecillion", " octodecillion", " novemdecillion", " vigintillion" };

        public static List<string> getSets(string number)
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
                    for (int ii = lastWord+1; ii<=i; ii++)
                    {
                        lastPart += split[ii] + " ";
                    }
                    sets.Add(lastPart);
                }



            }
            return sets;
        }
        
        public static List<long> getThousandSetValues(string number)
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

        public static long getSetValue( string set )
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
           


            return (long)((hundreds*100) + (tens*10) + ones);
        }

        public static long wordsToNumber(string words)
        {
            List<string> sets = getSets(words);
            List<long> thousandsMults = getThousandSetValues(words);
            long total = 0;


            

            for (int i = 0; i< sets.Count; i++)
            {
               
                string set = sets[i].Trim();
                long setVal = getSetValue(set);
                total += setVal * thousandsMults[i];
            }
            return total;
        }
        









    } 
}

