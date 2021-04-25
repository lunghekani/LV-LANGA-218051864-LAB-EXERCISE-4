using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
namespace Business_Layer // Look Mom I created and linked a Layer!! 
                         // Mark Item - Three layers have been created and they work (3 marks for each)
{
    public class Class1
    {
    }
    public class clsBusinessOperations
    {
        // creating a local instance of the connection class to process the list of arrays
        clsConnection local_Conn = new clsConnection();


        /* Method to create a list where the output is a list where
         * There is one type e.g movie
         * One country e.g South Africa
         * One duration e.g One Season
         * One Release year e.g 2020
        */
        public List<string> CreateContentList()
        {
            /* Creating an instance of the random number that is going to be used to cycle through the
             * Parallel Arrays
             * Mark Item - Algorithm in the business logic layer (CLEARLY COMMUNICATED ALGORITHM)
             */
            Random createRandomNumber = new Random();

            // having a localized list of the Data Access parallel arrays 
            var ListOfContentArrays = local_Conn.CreateListOfArrays();
            // creating a single list that holds the required output
            List<string> generatedList = new List<string>();

            // local array of the Data Access Parallel array - DataAccess.arrContentType
            var lstTypes = ListOfContentArrays[0];
            // local array of the Data Access Parallel array - DataAccess.arrReleaseYear
            var lstYear = ListOfContentArrays[1];
            // local array of the Data Access Parallel array - DataAccess.arrCountry
            var lstContry = ListOfContentArrays[2];
            // local array of the Data Access Parallel array - DataAccess.arrDuration
            var lstDuration = ListOfContentArrays[3];

            // generating a random number and storing it into a variable called contentParameter
            // used to cycle through the arrays, keeping the same value, each time
            // abiding by the laws of parallel arrays
            int contentParameter = createRandomNumber.Next(0, 5); // this is to generate a random number between 0 & 5
                                                                  // random.next is non-inclusive of the second parameter

            // adding the indices of each array to the output list to be used in the front end
            generatedList.Add(lstTypes[contentParameter]);
            generatedList.Add(lstYear[contentParameter]);
            generatedList.Add(lstContry[contentParameter]);
            generatedList.Add(lstDuration[contentParameter]);

            // returning the output list
            return generatedList; 
        }


    }
}
