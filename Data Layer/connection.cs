using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Data_Layer // Look Mom I created and linked a Layer!! 
                     // Mark Item - Three layers have been created and they work (3 marks for each)
{
    public class connection
    {
    }
    public class clsConnection
    { // Creating a Class to handle all the connection
      // operations to be sent for processing in the business layer
        public StreamReader createCSVConn()
        {
            // using a stream reader to be able to cycle through the CSV later
            var Csv_Stream = new StreamReader(@"../../labEx4 - data structures.csv"); // path to the CSV



            return Csv_Stream; // Returning the new stream reader
        }
        // method used to create the required parallel arrays for the Data Layer and return a list of them 
        // to be processed in the Business Layer
        public List<string[]> CreateListOfArrays()
        {
            // calling the CSV connection method
            var localCSV_StreamReader = createCSVConn();

            // creating the parallel arrays with a length of 5 because CSV
            // Mark Item - Parallel arrays in the data later
            string[] arrayContentTypes = new string[5];
            string[] arrayReleaseYear = new string[5];
            string[] arrayCountry = new string[5];
            string[] arrayContentDuration = new string[5];

            // count variable for the CSV stream to loop through
            int CountForCSVStream = 0;

            // looping through the CSV Stream to add the Data into their respective arrays
            while (!localCSV_StreamReader.EndOfStream)
            {
                if (CountForCSVStream == 5) // This limit is so that I dont exceed the bounds of the array
                {
                    break; // exits the while loop
                }
                else
                {



                    var line = localCSV_StreamReader.ReadLine();
                    var splitLineArray = line.Split(';'); // method that creates a temporary array housing the type, country, duration etc.

                    arrayContentTypes[CountForCSVStream] = splitLineArray[0]; // how the content type is taken at index 0 according to the CSV
                    arrayCountry[CountForCSVStream] = splitLineArray[1]; // how the content country is taken at index 1 according to the CSV
                    arrayReleaseYear[CountForCSVStream] = splitLineArray[2]; // how the content release year is taken at index 2 according to the CSV
                    arrayContentDuration[CountForCSVStream] = splitLineArray[3]; // how the content duration is taken at index 3 according to the CSV


                    CountForCSVStream++; // increase my count variable
                }


            }

            var listOfArrays = new List<string[]>(); // create a list to hold all the parallel arrays

            // adding arrays to list of arrays to be exported to the business layer and processed
            listOfArrays.Add(arrayContentTypes); 
            listOfArrays.Add(arrayReleaseYear);
            listOfArrays.Add(arrayCountry);
            listOfArrays.Add(arrayContentDuration);

            return listOfArrays; // returning the list of arrays
        }

    }
}
