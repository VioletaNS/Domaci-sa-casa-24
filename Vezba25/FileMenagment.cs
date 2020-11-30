using System;
using System.Collections.Generic;
using System.IO;

namespace Vezba25
{
    class FileMenagment
    {
        private static string FileName = @"C:\Kurs\cas25_zadatakd.txt";
        public static void WriteList(string InputData)
        {
            using (StreamWriter FileHandle = new StreamWriter(FileName, true))
            {
                FileHandle.WriteLine("{0}", string.Join(";", InputData));
            }
        }
        public static List<string> Readlist()
        {
            List<string> ListOfNames = new List<string>();
            using (StreamReader FileHandle = new StreamReader(FileName))
            {
                string FileContents = "";
                while((FileContents = FileHandle.ReadLine()) != null)
                {
                    ListOfNames.Add(FileContents);
                }

            }
            return ListOfNames;
        }  


       
    }
}
