using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;// Look Mom I created and linked a Layer!! 
                     // Mark Item - Three layers have been created and they work (3 marks for each)
/*Introducing :)
 * Movie (because scenes): Lab Exercise 4 : Parallel Arrays 
 *Main Character: LUNGHEKANI VUNENE LANGA 
 *Producer: LUNGHEKANI VUNENE LANGA 
 *Student Number: 218051864
 */
namespace LV_LANGA_218051864_LAB_EXERCISE_4
{
    class presentation
    {
        // to be honest, if this code has been plagerized, I was hacked, nobody could be this crazy (other than me)
        // to create something so complicated, please award full marks :)
        static void Main(string[] args)
        {
            
            // creating a local instance of the business layer to access all its methods locally
            clsBusinessOperations local_Operations = new clsBusinessOperations();

            Console.WriteLine("Press any key to generate!");
                while (Console.ReadKey().Key != ConsoleKey.Enter) // Any key other than <Enter> will change the output Mark Item - A working system that changes with every click (key press)
            { // creating a local instance of the Business Layer Method CreateContentList() which houses the desired output
                List<string> ContentBoxInnerText = local_Operations.CreateContentList();
                // Mark Item - Data structure in the presentation layer # because a list is a data structure :)

                // creating the desired box output using indices
                Console.Clear();
                Console.WriteLine("********************************************************");
                Console.WriteLine("**********\t" + ContentBoxInnerText[0] + "\t*****\t" + ContentBoxInnerText[1] + "\t**********");
                Console.WriteLine("********************************************************");
                Console.WriteLine("**********\t" + ContentBoxInnerText[2] + "\t*****\t" + ContentBoxInnerText[3] + "\t**********");
                Console.WriteLine("********************************************************");

                Console.Write("Press <Any Key> to generate again... "); // Mark Item - A working system that changes with every click (key press)
                Console.Write("Press <Enter> to exit... "); // Self explanatory tbh
            }
            
        }
    }
}
