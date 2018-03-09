using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAnalizer
{
    public class generateFizzBuzzNumbers
    {
        numberAnalizer checkNumber = new numberAnalizer();
        public int _initNumber { get; set; }
        public int _finishNumber { get; set; }
        private List<int> listNumbersGenerated = new List<int>();


        public generateFizzBuzzNumbers()
        {
            _initNumber = 5;
        }

        public int quantityItems()
        {
            return listNumbersGenerated.Count;
        }

        public void createItems(int valuesToGenerate)
        {
            for (int i = 0; i < valuesToGenerate; i++)
            {
                listNumbersGenerated.Add(i);
            }
        }


        public string showFizzOnThree(int numberToCheck)
        {
            if (checkNumber.checkIfOneIsFizz(numberToCheck))
            {
                return "Fizz";
            }
            else
            {
                return numberToCheck.ToString();
            }
        }

        public string showBuzOnThree(int numberToCheck)
        {
            if (checkNumber.checkIfOneIsBuzz(numberToCheck))
            {
                return "Buzz";
            }
            else
            {
                return numberToCheck.ToString();
            }
        }

        public string showSpecialNumbers(int numberToAnalize)
        {
            if (!checkNumber.checkIfOneIsFizzorBuzz(numberToAnalize))
            {
                return numberToAnalize.ToString();
            }
            else
            {
                return numberToAnalize.ToString().Replace("3", "Fizz").Replace("5", "Buzz");
            }
        }

        public void showNumbersFromListEvaluated()
        {
            foreach (int item in listNumbersGenerated)
            {
                if (ShowFizzOrBuzzUnique(item))
                {
                    showSpecialCases(item);
                }
            }
        }

        private void showSpecialCases(int item)
        {
            if (checkNumber.checkMultipleNumberAreFizzOrBuzz(item))
            {
                Console.WriteLine(showSpecialCasesUpdated(item));
            }
            else
            {
                Console.WriteLine(item);
            }

        }

        private string showSpecialCasesUpdated(int number)
        {
            string result = "";
            foreach (char item in number.ToString())
            {
                string tempValue = checkAndShowFizzBuzz(Int32.Parse(item.ToString()));
                if (string.IsNullOrEmpty(tempValue))
                {
                    result += item.ToString();
                }
                else
                {
                    result += tempValue;
                }
            }
            return result;
        }

        private bool ShowFizzOrBuzzUnique(int value)
        {
            string result = "";
            result = checkAndShowFizzBuzz(value);
            if (string.IsNullOrEmpty(result))
            {
                return true;
            }
            else
            {
                Console.WriteLine(result);
                return false;
            }
        }

        private string checkAndShowFizzBuzz(int value)
        {
            string result = "";
            if (checkNumber.checkIfOneIsFizzAndBuzz(value))
            {
                result = showFizzAndBuzz(value);
            }
            else
            {
                if (checkNumber.checkIfOneIsFizz(value))
                {
                    result = showFizzOnThree(value);
                }
                else
                {
                    if (checkNumber.checkIfOneIsBuzz(value))
                    {
                        result = showBuzOnThree(value);
                    }

                }
            }
            return result;
        }

        private string showFizzAndBuzz(int item)
        {
            return "FizzBuzz";
        }
    }
}
