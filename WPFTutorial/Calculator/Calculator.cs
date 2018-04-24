using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Calculator
    {
        private string storedNumber;
        private string currentNumber;
        private string operation;
        private bool overwrite;

        public Calculator()
        {
            storedNumber = "";
            currentNumber = "";
            operation = "";
            overwrite = false;
        }

        public void NumberInput(string number)
        {
            if(overwrite == true)
            {
                currentNumber = number;
                overwrite = false;
            }
            else
            {
                currentNumber += number;
            }
            
        }

        public void Calculate(string operation)
        {
            if(operation == "Enter")
            {
                operation = "";
            }
            if(storedNumber == "")
            {
                storedNumber = currentNumber;
                //currentNumber = "";
                this.operation = operation;
                overwrite = true;
            }
            else
            {
                if(this.operation == "+")
                {
                    double result = Convert.ToDouble(storedNumber) + Convert.ToDouble(currentNumber);
                    currentNumber = result.ToString();
                    storedNumber = "";
                    this.operation = operation;
                    overwrite = true;
                }
                else if(this.operation == "-")
                {
                    double result = Convert.ToDouble(storedNumber) - Convert.ToDouble(currentNumber);
                    currentNumber = result.ToString();
                    storedNumber = "";
                    this.operation = operation;
                    overwrite = true;
                }
                else if(this.operation == "*")
                {
                    double result = Convert.ToDouble(storedNumber) * Convert.ToDouble(currentNumber);
                    currentNumber = result.ToString();
                    storedNumber = "";
                    this.operation = operation;
                    overwrite = true;
                }
                else if(this.operation == "/")
                {
                    double result = Convert.ToDouble(storedNumber) / Convert.ToDouble(currentNumber);
                    currentNumber = result.ToString();
                    storedNumber = "";
                    this.operation = operation;
                    overwrite = true;
                }
            }
        }
        public void Clear()
        {
            operation = "";
            currentNumber = "";
            storedNumber = "";
        }

        public string GetCurrentNumber()
        {
            if(currentNumber == "")
            {
                return "0";
            }
            else
            {
                return currentNumber;
            }
            
        }
    }
}
