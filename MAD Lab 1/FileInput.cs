using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MAD_Lab_1
{
    class FileInput
    {

        private StreamReader input = null;
        private String fileName;

        public FileInput(String fileName)
        {
            this.fileName = fileName;
            try
            {
                input = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileRead()
        {
            String line;
            try
            {
                while ((line = input.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public String FileReadLine()
        {
            try
            {
                String line = input.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (input != null) {
                try
                {
                    input.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
