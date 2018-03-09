using numberAnalizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzzProyect
{
    class Program
    {

        static void Main(string[] args)
        {
            numberAnalizer.numberAnalizer checkNumber = new numberAnalizer.numberAnalizer();
            generateFizzBuzzNumbers generateNumeber = new generateFizzBuzzNumbers();
            RunTestCases(checkNumber, generateNumeber);
            generateNumeber.showNumbersFromListEvaluated();
        }

        private static void RunTestCases(numberAnalizer.numberAnalizer checkNumber, generateFizzBuzzNumbers generateNumeber)
        {
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(1) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(2) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(3) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(5) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(43) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzorBuzz(45) == true);
            Console.WriteLine("----");
            Console.WriteLine(checkNumber.checkIfOneIsFizzAndBuzz(1) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzAndBuzz(2) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzAndBuzz(15) == true);
            Console.WriteLine(checkNumber.checkIfOneIsFizzAndBuzz(30) == true);
            Console.WriteLine("----");
            Console.WriteLine("isFizz 1: " + (checkNumber.checkIfOneIsFizz(1) == true));
            Console.WriteLine("isFizz 2: " + (checkNumber.checkIfOneIsBuzz(2) == true));
            Console.WriteLine("isFizz 3: " + (checkNumber.checkIfOneIsFizz(3) == true));
            Console.WriteLine("isFizz 5: " + (checkNumber.checkIfOneIsBuzz(5) == true));
            Console.WriteLine("isFizz 43: " + (checkNumber.checkIfOneIsFizz(43) == true));
            Console.WriteLine("isFizz 45: " + (checkNumber.checkIfOneIsBuzz(45) == true));
            generateNumeber._initNumber = 0;
            generateNumeber._finishNumber = 100;
            Console.WriteLine("Init Number: " + numberIsEqualTo(generateNumeber._initNumber, 0));
            Console.WriteLine("Init Number: " + numberIsEqualTo(generateNumeber._initNumber, 5));
            Console.WriteLine("Init Number: " + numberIsEqualTo(generateNumeber._finishNumber, 100));
            Console.WriteLine("Init Number: " + numberIsEqualTo(generateNumeber._finishNumber, 50));

            Console.WriteLine(numberIsEqualTo(generateNumeber.quantityItems(), 100));
            generateNumeber.createItems(100);
            Console.WriteLine(numberIsEqualTo(generateNumeber.quantityItems(), 100));
            //generateNumeber.showNumbersFromList();
            Console.WriteLine("-----------------");
            Console.WriteLine(generateNumeber.showFizzOnThree(2));
            Console.WriteLine(generateNumeber.showFizzOnThree(3));
            Console.WriteLine(generateNumeber.showBuzOnThree(2));
            Console.WriteLine(generateNumeber.showBuzOnThree(5));
            Console.WriteLine(generateNumeber.showBuzOnThree(43));
            Console.WriteLine(generateNumeber.showBuzOnThree(45));
            Console.WriteLine(generateNumeber.showSpecialNumbers(45));
            Console.WriteLine(generateNumeber.showSpecialNumbers(43));
        }

        private static bool numberIsEqualTo(int quantityItems, int evaluationNumber)
        {
            if (quantityItems == evaluationNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
