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

            //todo: a way of just removing superfluous lines to prevent that easy error to run into

            return fileString;

        }

    }
}
