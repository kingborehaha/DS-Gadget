using System;
using System.IO;

namespace DS_Gadget
{
    class GetTxtResourceClass
    {
        public static string GetTxtResource(string filePath)
        {
           //Get local directory + file path, read file, return string contents of file

            Path.Combine(Environment.CurrentDirectory, filePath);

            string fileString = File.ReadAllText(filePath);

            return fileString;
        }

        public static bool IsValidTxtResource(string txtLine)
        {
            //see if txt resource line is valid and should be accepted 
            //(bare bones, only checks for a couple obvious things)

            if (txtLine.Contains("//"))
            {
                txtLine = txtLine.Substring(0, txtLine.IndexOf("//")); // remove everything after "//" comments

            };
            if (string.IsNullOrWhiteSpace(txtLine) == true) //empty line check
                return false;
            //else if(txtLine.Contains("//")) //ignore comments
                //return false;

            //line is valid
            return true;
        }
    }
}