using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        private void CalculatorGUIForm_Load(object sender, EventArgs e)
        {

        }


        private void button_ws(object sender, EventArgs e)
        {

        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Find the quotent and the remainder");
            Console.Write("Enter the number: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter the number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            var quotent = numberOne / numberTwo;
            var remaindere = numberOne % numberTwo;

            Console.WriteLine("The quotent of {0} and {1} is : {2}", numberOne, numberTwo, quotent);
            Console.WriteLine("The reminder of {0} and {1} is : {2}", numberOne, numberTwo, remaindere);
            Console.ReadLine();
        }

        private void buttonRS_Click(object sender, EventArgs e)
        {

        }

        private void buttonlog10_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Find log with bese ten");
            Console.Write("Enter the number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("The log the number {0} with base ten is: {1} ", numberOne, Math.Log10(numberOne));
            Console.ReadLine();
        }

        private void buttonSL_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Find log with bese ten");
            Console.Write("Enter the number: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter the base: ");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("The log the number {0} with base {1} is: {2} ", numberOne, Base, Math.Log(numberOne, Base));
            Console.ReadLine();
        }

        private void buttonMM_Click(object sender, EventArgs e)
        {
          
            Console.WriteLine("Find the min and max");
            Console.Write("Enter the number: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter the base: ");
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine("Number {0} is bigger that {1}", numberOne, numberTwo);
                Console.ReadLine();
            }
            else if (numberOne < numberTwo)
            {
                Console.WriteLine("Number {0} is smaller that {1}", numberOne, numberTwo);
                Console.ReadLine();

            }
        }

        private void button_SP(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Find the number raised to a power");
            Console.Write("Enter the number: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter the exponet: ");
            double expo = double.Parse(Console.ReadLine());

            var result = Math.Pow(numberOne, expo);

            Console.WriteLine("The number {0} to the power of {1} is: {2}", numberOne, expo, result);
            Console.ReadLine();
        }

        private void buttonQuadraticEq_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Please enter a b c");
            Console.Write("Enter the a : ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Enter the b : ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Enter the c : ");
            double C = double.Parse(Console.ReadLine());

            var Beesqr = Math.Pow(B, 2);
            var Disc = B * B - 4 * A * C;
            var SolutionPos = (-B + Disc) / (2 * A);
            var SolutionNeg = (-B - Disc) / (2 * A);

            Console.WriteLine("The Positive root is : {0}", SolutionPos);
            Console.WriteLine("The Negative root is : {0}", SolutionNeg);
            Console.ReadLine();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
           
                Console.Clear();
                Console.WriteLine("Find the square root of the given number");
                Console.Write("Enter the number: ");
                double number7 = double.Parse(Console.ReadLine());
                Console.WriteLine("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
           
        }

        private void buttonExit_click(object sender, EventArgs e)
        {

        }

        private void buttonWS_Click(object sender, EventArgs e)
        {

        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/