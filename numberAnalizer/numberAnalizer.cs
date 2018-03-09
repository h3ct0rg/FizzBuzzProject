using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAnalizer
{
    public class numberAnalizer
    {
        public bool checkIfOneIsFizzorBuzz(int valueToAnalize)
        {
            if ((valueToAnalize % 3) == 0 || (valueToAnalize % 5) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkMultipleNumberAreFizzOrBuzz(int valueToAnalize)
        {
            foreach (char item in valueToAnalize.ToString())
            {
                if (checkIfOneIsFizzorBuzz(Int32.Parse(item.ToString())))
                    return true;
            }
            return false;
        }

        public bool checkIfOneIsFizz(int valueToAnalize)
        {
            if ((valueToAnalize % 3) == 0)
                return true;
            else
            {
                return false;
            }
        }

        public bool checkIfOneIsBuzz(int valueToAnalize)
        {
            if ((valueToAnalize % 5) == 0)
                return true;
            else
            {
                return false;
            }
        }

        public bool checkIfOneIsFizzAndBuzz(int valueToAnalize)
        {
            return (valueToAnalize % 3) == 0 && (valueToAnalize % 5) == 0;
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
