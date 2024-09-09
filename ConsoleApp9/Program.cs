using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exchange rates (replace with actual values)
            Double USDToEURT = 0.90;// This the exchange rate for  US Dollars to Euros.
            Double USDToJPY = 143.59;// This the exchange rate for US Dollars to Japanesse Yen .
            Double EURToUSD = 1.11;// This the exchange rate for Euros to US Dollars
            Double EURToJPY = 159.19;// This the exchange rate for Euros to Japanesse Yen 
            Double JPYoUSD = 0.0070;//This the exchange rate for Japanesse Yen to US Dollars
            Double JPYoEURT = 0.00063;//This the exchange rate for Japanesse Yen to Euros 

            Console.WriteLine("Currency Converter");// displays prompts to user
            Console.WriteLine("Please enter the amount you want to convert:");// userr input for the amount to be converted and currenices to convert from and to
            double amount = double.Parse(Console.ReadLine());//input for amount is converted to double using double.Parse 

            Console.WriteLine("Please select the currency you want to convert from (USD, EUR, JPY):");//
            string fromCurrency = Console.ReadLine().ToUpper();//

            double convertedAmount = 0;//user's input is stored in the amount variable as a double.

            switch (fromCurrency)//code then asks the user to select the currency they want to convert from (USD, EUR, or JPY). The input is stored in the fromCurrency variable as a string.
            {
                case "USD":
                    Console.WriteLine("Please select the currency you want to convert to (USD, EUR, JPY):");// first display prompts the userto choose between USD, EUR, JPY .
                    string toCurrency = Console.ReadLine().ToUpper();//reads a line of text from the console input and stores it as a string.
                    switch (toCurrency)// switch statement is used to determine the "toCurrency" selected by the user.
                    {
                        case "EUR":
                            convertedAmount = amount * USDToEURT; //It calculates the converted amount by multiplying the original amount by the USDToEUR constant.
                            break;//statement is used to exit the switch statement after the conversion is performed.
                        case "JPY":
                            convertedAmount = amount * USDToJPY; ////It calculates the converted amount by multiplying the original amount by the USDToJPY constant.
                            break;//statement is used to exit the switch statement after the conversion is performed.
                        default:
                            Console.WriteLine("Invalid currency selected.");
                            break;//statement is used to exit the switch statement after the conversion is performed.
                    }
                    break; //statement is used to exit the switch statement after the conversion is performed.
                case "EUR":
                    Console.WriteLine("Please select the currency you want to convert to (USD, EUR, JPY):"); // second display prompts the userto choose between USD, EUR, JPY .
                    string Currency = Console.ReadLine().ToUpper();////reads a line of text from the console input and stores it as a string.
                    switch (Currency)// this is the switch staement for Currency
                    {
                        case "USD":
                            convertedAmount = amount * EURToUSD;//It calculates the converted amount by multiplying the original amount by the EURToUSD constant.
                            break; //statement is used to exit the switch statement after the conversion is performed.
                        case "JPY":
                            convertedAmount = amount * EURToJPY;//It calculates the converted amount by multiplying the original amount by the EURToJPY constant.
                            break;//statement is used to exit the switch statement after the conversion is performed.
                        default://default is a catch-all statement that is executed if none of the previously defined cases match the value being evaluated.
                            Console.WriteLine("Invalid currency selected.");
                            break;//statement is used to exit the switch statement after the conversion is performed.
                    }
                    break;//statement is used to exit the switch statement after the conversion is performed.
                case "JPY":
                    Console.WriteLine("Please select the currency you want to convert to (USD, EUR, JPY):");//// three display prompts the userto choose between USD, EUR, JPY .
                    string vCurrency = Console.ReadLine().ToUpper();////reads a line of text from the console input and stores it as a string.
                    switch (vCurrency)// this is the switch staement for vCurrency
                    {
                        case "USD":
                            convertedAmount = amount * JPYoUSD;//It calculates the converted amount by multiplying the original amount by the JPYtoUSD constant.
                            break;//statement is used to exit the switch statement after the conversion is performed.
                        case "EUR":
                            convertedAmount = amount * JPYoEURT;
                            break;//statement is used to exit the switch statement after the conversion is performed.
                        default://default is a catch-all statement that is executed if none of the previously defined cases match the value being evaluated.
                            Console.WriteLine("Invalid currency selected.");
                            break;//statement is used to exit the switch statement after the conversion is performed.
                    }
                    break;//statement is used to exit the switch statement after the conversion is performed.
                default: // default is a catch-all statement that is executed if none of the previously defined cases match the value being evaluated.
                    Console.WriteLine("Invalid currency selected.");
                    break;//statement is used to exit the switch statement after the conversion is performed.
            }

            Console.WriteLine("Converted amount: " + convertedAmount);//string "Converted amount: " with the value of the convertedAmount variable. The + operator is used for string concatenation and displays the final converted amount to the user.
        }
    }
}