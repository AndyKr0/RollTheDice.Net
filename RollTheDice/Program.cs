using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator will be our "dice"
            Random r = new Random();

            // Get input from console and recast to Int32
            Console.WriteLine("How many dice should we roll?");
            int diceAmt = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("How many rolls?");
            int rollsAmt = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine("Rolling {0} dice {1} time(s)!", diceAmt, rollsAmt);

            // Lets save each roll to an array
            int[,] rollArray = new int[rollsAmt, diceAmt];


            // Roll the dice
            for (int i = 0; i < rollsAmt; i++)
            {
                //Console.WriteLine("Roll Number {0}", i + 1);

                for (int j = 0; j < diceAmt; j++)
                {
                    int num = r.Next(1, 7);
                    //Console.WriteLine(num.ToString());
                    rollArray[i, j] = num;
                }
            }

            // Output the results from our array
            Console.WriteLine("---------------");
            for (int i = 0; i < rollsAmt; i++)
            {
                Console.WriteLine("---------------\nRoll {0}:\n---------------", i + 1);
                for (int j = 0; j < diceAmt; j++)
                {
                    //Console.WriteLine("Die {0}:", j);
                    Console.WriteLine(rollArray[i, j].ToString());
                }
            }
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            // Draws a simple graphical display of how frequently numbers were rolled.
            Console.WriteLine("---------------\nRoll Frequency\n---------------");
            for (int k = 1; k < 7; k++)
            {
                
                Console.Write(k);
                for (int i = 0; i < rollsAmt; i++)
                {
                    
                    for (int j = 0; j < diceAmt; j++)
                    {

                        {
                            
                            if (rollArray[i, j] == k)
                            {
                                Console.Write("+");
                            }
                            
                        }
                    }
                    

                }
                Console.Write("\n");
            }

            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            // Draws a  graphical display of how frequently totals were rolled.
            Console.WriteLine("---------------\nTotals\n---------------");
            for (int k = diceAmt; k <= 6 * diceAmt ; k++)
            {
               Console.Write(k.ToString().PadLeft(2, ' '));
               for (int i = 0; i < rollsAmt; i++)
               {
                    int rollSum = 0;
                    for (int j = 0; j < diceAmt; j++)
                    {
                        rollSum = rollArray[i,j] + rollSum ;
                    }
                    if (rollSum == k)
                    {
                        Console.Write("+");
                    }
                    
                }
                Console.Write("\n");
            }
            
            Console.WriteLine("Press 'Enter' to exit.");
            Console.ReadLine();
        }
    }
}
    

        
           

        
 

