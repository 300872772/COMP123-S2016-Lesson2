using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *Author: Md Mamunur Rahman
 * Date: May 17, 2016
 * Date Modified: May 17, 2016
 * Description: Advanced Methods Demo for Lesson2
 * Version: 0.0.2 - Added adXandY Method 
 */


namespace COMP123_S2016_Lesson2
{
    /**
 * Main Driver Class for Lesson2
 * 
 * @class Program
 * */

    public class Program
    {

        /**
         * Main Method for Driver Class
         * 
         * @constructor Main
         * @pram {string[]} args
         * */
        static void Main(string[] args)
        {

            int x = 50;
            int y = 40;
            int result = 0;
            result = addXandY(x, y);
           Console.WriteLine(result);

        }

        /**
         * simple method to add 2 values
         * 
         * @method adXandY
         * @param {int} firstNumber
         * @param {int} secondNumber
         
         */

        public static int addXandY(int furstNumber, int secondNumber)

        {
            int result = 0;
            result = furstNumber + secondNumber;

            return result;
        }


    }
}
