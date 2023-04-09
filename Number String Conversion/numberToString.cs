using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;


namespace Number_String_Conversion
{
    public static class numberToString 
    {
        private static string[] onesList = {"", " one", " two",  " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " fourteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
        private static string[] tensList = {"", " twenty", " thirty", " forty", " fifty", " sixty", " seventy", " eighty", " ninety" };
        private static string[] thousandsList = {"", " thousand", " million", " billion", " trillion", " quadrillion", " quintillion", " sextillion", " septillion", " octillion", " nonillion", " decillion", " undecillion", " duodecillion", " tredecillion", " quattuordecillion", " quindecillion", " sexdecillion", " septendecillion", " octodecillion", " novemdecillion", " vigintillion" };

        private static string convertSet(string hundredStr) //Takes string as parameter, so no conversion issues from int,long, etc. to byte
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

        public static string convertStringToNumberWords( string number)
        {
            string newString = "";
            if (number.Trim() == "0")
            {
                return "zero";
            }else if (number.StartsWith("-"))
            {
                newString = "minus";
            }

            
            List<string> sets = convertStringToSets(number);
            int reverseCount = sets.Count;

            foreach (string set in sets)
            { 
                
                if (int.Parse( set ) > 0)
                {
                    newString += " "  + convertSet(set).Trim();
                    newString += thousandsList[reverseCount - 1] ;
                }
                
                reverseCount -= 1;
            }

            return newString.Trim();

        }

        
    }
}
