using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;


namespace Number_String_Conversion
{
    public static class NumberToWords 
    {
        //Create arrays to search for number values
        private static string[] onesList = {"", " one", " two",  " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
        private static string[] tensList = {"", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety" };
        private static string[] thousandsList = {"", " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion", " undecillion", " duodecillion", " tredecillion", " quattuordecillion", " quindecillion", " sexdecillion", " septendecillion", " octodecillion", " novemdecillion", " vigintillion" };

        //This method takes string as parameter, so no conversion issues from int,long, etc. to byte
        //Creates words for a set value
        //A set is a group of three digits
        //This is done by first checking if there is a hundred value
        //After checking for that and adding it, we search for ones or tens values
        // hundredStr = 3 digit number in string format ex: "132"
        private static string convertSet(string hundredStr)
        {
            short hundred = short.Parse(hundredStr);
            string returnString = " ";
            int hundreds = (int)( hundred / 100 );
            int ones = (int)( hundred- hundreds*100 );
            int tens = (int)(ones / 10);

            returnString += onesList[hundreds];
            if (hundreds > 0) {returnString += " hundred";};
            if (ones < 20)
            {
                returnString += onesList[ones];
            }
            else
            {
                returnString += tensList[tens-1];
                if (ones-tens > 0 && onesList[ones - tens * 10] == "")
                {
                    returnString += onesList[ones - tens * 10];
                }else if (ones - tens > 0){
                    returnString += "-" + onesList[ones - tens * 10].TrimStart() ;
                }
            }
            return returnString;
        }

        //This method converts a number into sets
        //A set is a group of three digits
        //This is done by first taking off the front portion of the number whether it is 1 or 3 digits
        //Next we can just substring each set of 3 digits and add them to a list to return
        // number = number in string format ex: "132094"
        private static List<string> convertStringToSets( string number)
        {
            if (number.StartsWith("-"))
            {
                number = number.Substring(1, number.Length - 1);
            }
            
            List<string> threes = new List<string>();
            byte numberOfSets = (byte)(number.Length / 3);
            byte firstSetLength = 0; 

            if (number.Length % 3 > 0)
            {
                firstSetLength = (byte)(number.Length % 3);
            }

            if (firstSetLength > 0)
            {
                threes.Add(number.Substring(0, firstSetLength));
            }

            for (int i = firstSetLength; i < numberOfSets * 3 + firstSetLength; i += 3)
            {
                threes.Add(number.Substring(i, 3));
            }
            return threes;
        }

        //This method converts a number value in string format and turns it into the word value for it
        //This is done by first checking if the number is negative, and then converting it into sets
        //And calculating the set values with other methods
        // number = number in string format ex: "132094"
        /// <summary>Converts number string value to words</summary>
        /// <param name="number">Ex: "-430101"</param>
        public static string Convert(string number)
        {
            string newString = "";
            if (number.Trim() == "0")
            {
                return "zero";
            }
            else if (number.StartsWith("-"))
            {
                newString = "negative";
            }

            List<string> sets = convertStringToSets(number);
            int reverseCount = sets.Count;

            foreach (string set in sets)
            {
                if (int.Parse(set) > 0)
                {
                    newString += " " + convertSet(set).Trim();
                    newString += thousandsList[reverseCount - 1];
                }
                reverseCount -= 1;
            }
            return newString.Trim();
        }
    }
}
