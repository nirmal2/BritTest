using System.Collections.Generic;

namespace BritTest
{
    public class Calculator
    {
        private static double applyNumber = 0;
        private static double addNumber = 0;
        private static double subNumber = 0;
        private static double multiplyNumber = 1;
        private static double divideNumber = 1;

        public static double calculate(Dictionary<string, double> instructions)
        {

            foreach (var keyValue in instructions)
            {
                switch (keyValue.Key)
                {
                    case "apply":
                        applyNumber = keyValue.Value;
                        break;
                    case "add":
                        addNumber = keyValue.Value;
                        break;
                    case "sub":
                        subNumber = keyValue.Value;
                        break;
                    case "multiply":
                        multiplyNumber = keyValue.Value;
                        break;
                    case "divide":
                        divideNumber = keyValue.Value;
                        break;
                } 
               
            }



            double result = (applyNumber + addNumber - subNumber) * multiplyNumber / divideNumber;
            return result;
        }

    }
}