using System;
using System.IO;

namespace DS_Gadget
{
    class GetTxtResourceClass
    {

        //new
        public static string GetTxtResource(string filePath)
        {

            Path.Combine(Environment.CurrentDirectory, filePath);

            string fileString = File.ReadAllText(filePath);

            //fileString.Replace("\n\n", ""); //remove any empty new lines
            //need a better way of just removing superfluous lines to prevent a dumbly easy error to run into

            return fileString;

        }

    }
}
