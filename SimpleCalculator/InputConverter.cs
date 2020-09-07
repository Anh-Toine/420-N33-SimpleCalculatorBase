using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
           
            if (!double.TryParse(argTextInput, out convertedNumber)) 
            {
                throw new ArgumentException(String.Format("Unkown numerical value: {0}",argTextInput));
            } 
            return convertedNumber;
        }
       
    }
}
