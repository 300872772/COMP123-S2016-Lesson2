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
 * Version: 0.0.5 - added readUntilEnd Method
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

            int numberOfEntries;

          
                Console.Write("How many entries do you want to make?");
                int.TryParse(Console.ReadLine(),out numberOfEntries);

               if( numberOfEntries>0)
                {

                    readUntilEnd(numberOfEntries);
                }


          
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

        /**
         * this methd llows the user tp make a variable number 0f string entries into a string array
         * 
         * @method addYtoX
         * @param {int} numberOfEntries
         * @return {int}
         * */

        public static int readUntilEnd( int numberOfEntries)
        {

            string[] inputs;

          int inputCounter=0;
          inputs = new string[numberOfEntries];



            do
            {
              
                Console.WriteLine("Enter a Value ('end' to stop): ");
                inputs[inputCounter] = "";
                inputs[inputCounter] = Console.ReadLine();

                    inputCounter++;
           
            } while ((inputs[inputCounter-1]!="end") && (inputCounter < numberOfEntries));

      
            return inputCounter; 
        }



        /**
        * this methd llows the user tp make a variable number 0f string entries into a string array
        * 
        * @method addYtoX
        * @param {int} numberOfEntries
        * @return {int}
        * */

        public static string[] readUntilEnd()
        {
            //variable declearation

            int numberOfEntries = 5;

            string[] inputs = new string[numberOfEntries];

            int inputCounter = 0;
            

            //execution of code

            do
            {

                Console.WriteLine("Enter a Value ('end' to stop): ");
                inputs[inputCounter] = "";
                inputs[inputCounter] = Console.ReadLine();

                inputCounter++;

            } while ((inputCounter != -1) && (inputCounter < numberOfEntries));


            return inputs;
        }
    }
}
