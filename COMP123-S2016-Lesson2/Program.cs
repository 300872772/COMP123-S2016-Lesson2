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
 * Version: 0.0.4 - added Test addYtoXTestMethod and run test
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

            Console.WriteLine();

            addYtoX(ref x,ref y);

            Console.WriteLine(x);
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

        /**
         *simple method to demostrait pass by reference with ref keyword 
         * @pram {ref int} X
         * @pram {ref int} Y
         */
        public static int addYtoX(ref int X, ref int Y )
        {

           return X += Y;

        }
    }
}
